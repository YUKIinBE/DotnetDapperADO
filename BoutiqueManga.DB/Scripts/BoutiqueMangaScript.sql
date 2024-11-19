SET IDENTITY_INSERT [dbo].[User] ON

INSERT INTO [dbo].[User] (Id, Password, Firstname, Lastname, Email, Address, Telephone, isSeller) VALUES
(1, 'Mickey123', 'Mickey', 'Mouse', 'mickey.mouse@disney.com', '123 Disney Lane, Anaheim, CA', '123-456-7890', 1),
(2, 'Minnie123', 'Minnie', 'Mouse', 'minnie.mouse@disney.com', '124 Disney Lane, Anaheim, CA', '123-456-7891', 0),
(3, 'Donald123', 'Donald', 'Duck', 'donald.duck@disney.com', '125 Disney Lane, Anaheim, CA', '123-456-7892', 0),
(4, 'Goofy123', 'Goofy', 'Goof', 'goofy.goof@disney.com', '126 Disney Lane, Anaheim, CA', '123-456-7893', 0),
(5, 'Pluto123', 'Pluto', 'Dog', 'pluto.dog@disney.com', '127 Disney Lane, Anaheim, CA', '123-456-7894', 0),
(6, 'Ariel123', 'Ariel', 'Princess', 'ariel.princess@disney.com', '128 Disney Lane, Anaheim, CA', '123-456-7895', 0),
(7, 'Simba123', 'Simba', 'Lion', 'simba.lion@disney.com', '129 Disney Lane, Anaheim, CA', '123-456-7896', 0),
(8, 'Elsa123', 'Elsa', 'Snow', 'elsa.snow@disney.com', '130 Disney Lane, Anaheim, CA', '123-456-7897', 0),
(9, 'Anna123', 'Anna', 'Frozen', 'anna.frozen@disney.com', '131 Disney Lane, Anaheim, CA', '123-456-7898', 0),
(10, 'Buzz123', 'Buzz', 'Lightyear', 'buzz.lightyear@disney.com', '132 Disney Lane, Anaheim, CA', '123-456-7899', 0);

SET IDENTITY_INSERT [dbo].[User] OFF;

SET IDENTITY_INSERT [dbo].[Collection] ON

INSERT INTO [dbo].[Collection] (Id, Image, Title, Author, Price, PublishedDate) VALUES
(1, 'image_url_1', 'One Piece', 'Eiichiro Oda', 9.99, '1997-07-22'),
(2, 'image_url_2', 'Naruto', 'Masashi Kishimoto', 8.99, '1999-09-21'),
(3, 'image_url_3', 'Attack on Titan', 'Hajime Isayama', 10.99, '2009-09-09'),
(4, 'image_url_4', 'Death Note', 'Tsugumi Ohba', 7.99, '2003-04-02'),
(5, 'image_url_5', 'Fullmetal Alchemist', 'Hiromu Arakawa', 12.99, '2001-07-18'),
(6, 'image_url_6', 'My Hero Academia', 'Kohei Horikoshi', 9.49, '2014-07-07'),
(7, 'image_url_7', 'Demon Slayer: Kimetsu no Yaiba', 'Koyoharu Gotouge', 11.99, '2016-02-15'),
(8, 'image_url_8', 'One Punch Man', 'ONE', 10.50, '2012-06-14'),
(9, 'image_url_9', 'Dragon Ball', 'Akira Toriyama', 8.50, '1984-09-20'),
(10, 'image_url_10', 'Bleach', 'Tite Kubo', 9.75, '2001-08-07');

SET IDENTITY_INSERT [dbo].[Collection] OFF;

SET IDENTITY_INSERT [dbo].[Editor] ON

INSERT INTO [dbo].[Editor] (Id, Name) VALUES
(1, 'Shueisha'),        -- For One Piece, Naruto, and others
(2, 'Kodansha'),        -- For Attack on Titan, My Hero Academia, etc.
(3, 'VIZ Media'),       -- For Death Note and others
(4, 'Square Enix');     -- For Fullmetal Alchemist

SET IDENTITY_INSERT [dbo].[Editor] OFF;


INSERT INTO [dbo].[Volume] (ISBN, VolNumber, CoverImage, Stock, EditorId, CollectionId) VALUES
('9781234567890', 1, 'image_url_1_vol1', 100, 1, 1),
('9781234567891', 2, 'image_url_1_vol2', 80, 1, 1),
('9781234567892', 1, 'image_url_2_vol1', 150, 1, 2),
('9781234567893', 2, 'image_url_2_vol2', 120, 1, 2),
('9781234567894', 3, 'image_url_2_vol3', 100, 1, 2),
('9781234567895', 1, 'image_url_3_vol1', 120, 2, 3),
('9781234567896', 1, 'image_url_4_vol1', 80, 3, 4),
('9781234567897', 2, 'image_url_4_vol2', 70, 3, 4),
('9781234567898', 1, 'image_url_5_vol1', 90, 4, 5),
('9781234567899', 2, 'image_url_5_vol2', 60, 4, 5),
('9781234567900', 1, 'image_url_6_vol1', 130, 2, 6),
('9781234567901', 2, 'image_url_6_vol2', 110, 2, 6),
('9781234567902', 1, 'image_url_7_vol1', 110, 1, 3),
('9781234567903', 2, 'image_url_7_vol2', 90, 1, 3),
('9781234567904', 1, 'image_url_8_vol1', 140, 1, 1),
('9781234567905', 1, 'image_url_9_vol1', 100, 1, 4),
('9781234567906', 2, 'image_url_9_vol2', 80, 1, 4),
('9781234567907', 1, 'image_url_10_vol1', 50, 1, 2),
('9781234567908', 2, 'image_url_10_vol2', 40, 1, 2),
('9781234567909', 3, 'image_url_10_vol3', 30, 1, 2);

SET IDENTITY_INSERT [dbo].[MMUserVolume] ON

INSERT INTO [dbo].[MMUserVolume] (Id, PurchaseDate, Quantity, UserId, VolumeISBN) VALUES
(1, '2024-01-15', 2, 1, '9781234567890'),  -- Mickey buys 2 copies of One Piece Vol 1
(2, '2024-01-16', 1, 2, '9781234567891'),  -- Minnie buys 1 copy of One Piece Vol 2
(3, '2024-01-17', 3, 3, '9781234567892'),  -- Donald buys 3 copies of Naruto Vol 1
(4, '2024-01-18', 1, 4, '9781234567893'),  -- Goofy buys 1 copy of Naruto Vol 2
(5, '2024-01-19', 4, 5, '9781234567894'),  -- Pluto buys 4 copies of Naruto Vol 3
(6, '2024-01-20', 2, 6, '9781234567895'),  -- Ariel buys 2 copies of Attack on Titan Vol 1
(7, '2024-01-21', 1, 7, '9781234567896'),  -- Simba buys 1 copy of Death Note Vol 1
(8, '2024-01-22', 5, 8, '9781234567897'),  -- Elsa buys 5 copies of Death Note Vol 2
(9, '2024-01-23', 2, 9, '9781234567898'),  -- Anna buys 2 copies of Fullmetal Alchemist Vol 1
(10, '2024-01-24', 3, 10, '9781234567899'), -- Buzz buys 3 copies of Fullmetal Alchemist Vol 2
(11, '2024-01-25', 1, 1, '9781234567900'),  -- Mickey buys 1 copy of My Hero Academia Vol 1
(12, '2024-01-26', 4, 2, '9781234567901'),  -- Minnie buys 4 copies of My Hero Academia Vol 2
(13, '2024-01-27', 2, 3, '9781234567902'),  -- Donald buys 2 copies of Demon Slayer Vol 1
(14, '2024-01-28', 3, 4, '9781234567903'),  -- Goofy buys 3 copies of Demon Slayer Vol 2
(15, '2024-01-29', 1, 5, '9781234567904'),  -- Pluto buys 1 copy of One Punch Man Vol 1
(16, '2024-01-30', 5, 6, '9781234567905'),  -- Ariel buys 5 copies of Dragon Ball Vol 1
(17, '2024-01-31', 2, 7, '9781234567906'),  -- Simba buys 2 copies of Dragon Ball Vol 2
(18, '2024-02-01', 3, 8, '9781234567907'),  -- Elsa buys 3 copies of Bleach Vol 1
(19, '2024-02-02', 4, 9, '9781234567908'),  -- Anna buys 4 copies of Bleach Vol 2
(20, '2024-02-03', 1, 10, '9781234567909'), -- Buzz buys 1 copy of Bleach Vol 3
(21, '2024-02-04', 2, 1, '9781234567890'),  -- Mickey buys 2 copies of One Piece Vol 1
(22, '2024-02-05', 1, 2, '9781234567891'),  -- Minnie buys 1 copy of One Piece Vol 2
(23, '2024-02-06', 3, 3, '9781234567892'),  -- Donald buys 3 copies of Naruto Vol 1
(24, '2024-02-07', 1, 4, '9781234567893'),  -- Goofy buys 1 copy of Naruto Vol 2
(25, '2024-02-08', 4, 5, '9781234567894'),  -- Pluto buys 4 copies of Naruto Vol 3
(26, '2024-02-09', 2, 6, '9781234567895'),  -- Ariel buys 2 copies of Attack on Titan Vol 1
(27, '2024-02-10', 1, 7, '9781234567896'),  -- Simba buys 1 copy of Death Note Vol 1
(28, '2024-02-11', 5, 8, '9781234567897'),  -- Elsa buys 5 copies of Death Note Vol 2
(29, '2024-02-12', 2, 9, '9781234567898'),  -- Anna buys 2 copies of Fullmetal Alchemist Vol 1
(30, '2024-02-13', 3, 10, '9781234567899'), -- Buzz buys 3 copies of Fullmetal Alchemist Vol 2
(31, '2024-02-14', 1, 1, '9781234567900'),  -- Mickey buys 1 copy of My Hero Academia Vol 1
(32, '2024-02-15', 4, 2, '9781234567901'),  -- Minnie buys 4 copies of My Hero Academia Vol 2
(33, '2024-02-16', 2, 3, '9781234567902'),  -- Donald buys 2 copies of Demon Slayer Vol 1
(34, '2024-02-17', 3, 4, '9781234567903'),  -- Goofy buys 3 copies of Demon Slayer Vol 2
(35, '2024-02-18', 1, 5, '9781234567904'),  -- Pluto buys 1 copy of One Punch Man Vol 1
(36, '2024-02-19', 5, 6, '9781234567905'),  -- Ariel buys 5 copies of Dragon Ball Vol 1
(37, '2024-02-20', 2, 7, '9781234567906'),  -- Simba buys 2 copies of Dragon Ball Vol 2
(38, '2024-02-21', 3, 8, '9781234567907'),  -- Elsa buys 3 copies of Bleach Vol 1
(39, '2024-02-22', 4, 9, '9781234567908'),  -- Anna buys 4 copies of Bleach Vol 2
(40, '2024-02-23', 1, 10, '9781234567909'), -- Buzz buys 1 copy of Bleach Vol 3
(41, '2024-02-24', 2, 1, '9781234567890'),  -- Mickey buys 2 copies of One Piece Vol 1
(42, '2024-02-25', 1, 2, '9781234567891'),  -- Minnie buys 1 copy of One Piece Vol 2
(43, '2024-02-26', 3, 3, '9781234567892'),  -- Donald buys 3 copies of Naruto Vol 1
(44, '2024-02-27', 1, 4, '9781234567893'),  -- Goofy buys 1 copy of Naruto Vol 2
(45, '2024-02-28', 4, 5, '9781234567894'),  -- Pluto buys 4 copies of Naruto Vol 3
(46, '2024-02-29', 2, 6, '9781234567895'),  -- Ariel buys 2 copies of Attack on Titan Vol 1
(47, '2024-03-01', 1, 7, '9781234567896'),  -- Simba buys 1 copy of Death Note Vol 1
(48, '2024-03-02', 5, 8, '9781234567897'),  -- Elsa buys 5 copies of Death Note Vol 2
(49, '2024-03-03', 2, 9, '9781234567898'),  -- Anna buys 2 copies of Fullmetal Alchemist Vol 1
(50, '2024-03-04', 3, 10, '9781234567899'); -- Buzz buys 3 copies of Fullmetal Alchemist Vol 2

SET IDENTITY_INSERT [dbo].[MMUserVolume] OFF;
