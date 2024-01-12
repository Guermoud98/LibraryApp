CREATE DATABASE libraryApp;
use libraryApp;
SELECT * FROM dbo.__EFMigrationsHistory;
SELECT * FROM Adherents;
DELETE FROM Adherents WHERE idAdherent = 3;
SELECT * FROM Livres;
SELECT * FROM Reservations;
UPDATE Livres SET Disponible = 'Oui' WHERE IdLivre = 3;
UPDATE Livres SET Categorie = 'Business' Where idLivre = 7;
UPDATE Livres SET Categorie = 'Science' Where idLivre = 6;
UPDATE Livres SET Categorie = 'History' Where idLivre = 17;
UPDATE Livres SET Disponible = 'Disponible';
INSERT INTO Livres(Description) VALUES ('*THE INSTANT NEW YORK TIMES BESTSELLER * A Times Best Science and Environment Book of 2023“Exceptional. . . Forceful, engaging and funny . . . This book will make you happy to live on this planet — a good thing, because you’re not leaving anytime soon.” —New York Times Book ReviewFrom the bestselling authors of Soonish, a brilliant and hilarious off-world investigation into space settlement

Earth is not well. The promise of starting life anew somewhere far, far away—no climate change, no war, no Twitter—beckons, and settling the stars finally seems within our grasp. Or is it? Critically acclaimed, bestselling authors Kelly and Zach Weinersmith set out to write the essential guide to a glorious future of space settlements, but after years of research, they aren’t so sure it’s a good idea. Space technologies and space business are progressing fast, but we lack the knowledge needed to have space kids, build space farms, and create space nations in a way that doesn’t spark conflict back home. In a world hurtling toward human expansion into space, A City on Mars investigates whether the dream of new worlds won’t create nightmares, both for settlers and the people they leave behind. In the process, the Weinersmiths answer every question about space you’ve ever wondered about, and many you’ve never considered:

Can you make babies in space? Should corporations govern space settlements? What about space war? Are we headed for a housing crisis on the Moon’s Peaks of Eternal Light—and what happens if you’re left in the Craters of Eternal Darkness? Why do astronauts love taco sauce? Speaking of meals, what’s the legal status of space cannibalism?

With deep expertise, a winning sense of humor, and art from the beloved creator of Saturday Morning Breakfast Cereal, the Weinersmiths investigate perhaps the biggest questions humanity will ever ask itself—whether and how to become multiplanetary.

Get in, we’re going to Mars.');
DELETE FROM Reservations WHERE idReservation = 1017;
