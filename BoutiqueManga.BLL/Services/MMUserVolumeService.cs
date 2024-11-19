using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BoutiqueManga.BLL.Interfaces;
using BoutiqueManga.BLL.Mappers;
using BoutiqueManga.BLL.Models;
using BoutiqueManga.DAL.Interfaces;

namespace BoutiqueManga.BLL.Services
{
    public class MMUserVolumeService(IMMUserVolumeRepository repo, IVolumeRepository repoVolume, ICollectionRepository repoCollection) : IMMUserVolumeService
    {
        public IEnumerable<MMUserVolume> Get(int? userId = null, string? isbn = null)
        {
            return repo.Get(userId, isbn).Select(entity => entity.ToModel());
        }

        public MMUserVolume GetById(int id)
        {
            return repo.GetById(id).ToModel();
        }

        public IEnumerable<MMUserVolume> GetByUserId(int userId)
        {
            return repo.GetByUserId(userId).Select(entity => entity.ToModel());
        }

        public MMUserVolume? Create(MMUserVolume mmUserVolume)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    Volume volume = repoVolume.GetByISBN(mmUserVolume.VolumeISBN).ToModel();
                    decimal price = repoCollection.GetById(volume.CollectionId).Price;

                    CalculateBill(mmUserVolume, price);

                    // Check if there is enough stock
                    if(volume.Stock > mmUserVolume.Quantity)
                    {

                        MMUserVolume result =  repo.Create(mmUserVolume.ToEntity()).ToModel();
                        repoVolume.UpdateStockByISBN(mmUserVolume.VolumeISBN, (mmUserVolume.Quantity * -1));
                        

                        if (volume.Stock <= 0)
                        {
                            //TODO NotifySeller
                        }
                        scope.Complete();
                        return result;
                    }
                    else
                    {
                        throw new NotImplementedException("Not enough Stock");
                        //TODO Add NotEnoughStockException()
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Returns if there is a free item. If there is, it outputs the number of free items. Ex: 25 purchases(quantity) for 10(requiredPurchasesForFreeItem) + 1 free, it returns 2 free items.
        /// </summary>
        /// <param name="requiredPurchasesForFreeItem"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        private bool CheckForFreeItems(int requiredPurchasesForFreeItem, int quantity, out int freeItems)
        {
            freeItems = quantity / (requiredPurchasesForFreeItem + 1);
            return freeItems > 0? true : false;
        }

        private void CalculateBill(MMUserVolume newPurchase, decimal price)
        {
            // Calculate the total purchase of the user
            int totalPurchase = 0;
            foreach (var history in Get(newPurchase.UserId))
            {
                totalPurchase += history.Quantity;
            }

            // Calculate the number of carried over items from past purchases.
            // ex: if total = 25 and 10 + 1 FREE, the user should have already recieved 11th and 22th items for free. 3 will be counted to the next free item (33).
            int requiredPurchasesForFreeItem = 10;
            int carriedOver = totalPurchase % (requiredPurchasesForFreeItem + 1);
            int quantityToCheck = carriedOver + newPurchase.Quantity;

            // If there is a free item, it will be subtracted from the totalPrice.
            if (CheckForFreeItems(requiredPurchasesForFreeItem, quantityToCheck, out int freeQuantity))
            {
                newPurchase.TotalPrice = price * (newPurchase.Quantity - freeQuantity);
            }
            else
            {
                newPurchase.TotalPrice = price * newPurchase.Quantity;
            }
        }
    }
}
