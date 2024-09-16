# Zadania przypominające :)

1. [Łatwe] Uruchamiamy Visual Studio
2. [Łatwe] Tworzymy nowy projekt Console App i nadajemy nazwę PowtorkaKonsola.
3. [Łatwe] Napisać kod, który wyświetli na konsoli tekst: Witam, to jest mój program konsolowy –
TwojeImię. Nie zapomnij dodać odpowiedniej linijki, aby konsola po od razu po uruchomieniu programu
się nie wyłączała.
4. [Łatwe] Dodać do programu zmienne wraz z przypisaniem do nich dowolnych wartości zwracając
uwagę na odpowiedni typ zmiennej:
● ulubionaPotrawa (typ tekstowy),
● wiek (typ liczbowy całkowity),
● kieszonkowe (typ pieniężny, zmiennoprzecinkowy),
● rozmiar (typ znakowy) – nadać wartość S, M lub L
● czyEkstraRozmiar (typ logiczny)
5. [Łatwe] Wyświetlić na konsoli tekst: Mam (wiek) lat i lubię (ulubionaPotrawa), gdzie wiek i ulubiona
potrawa powinny być pobierane ze stworzonych wcześniej zmiennych.
6. [Średnie] Napisać kod, który wypisze na ekranie 50 razy Jestem głodny. Skorzystać do tego celu z
pętli for.
7. [Średnie] Napisać kod, który poprosi użytkownika o wpisanie, ile kosztuje jedna porcja ulubionej
potrawy, która została zapisana w zmiennej ulubionaPotrawa i zapiszę ją w nowej zmiennej cena.
8. [Średnie] Dopisać do programu kod obliczający, ile porcji ulubionej potrawy można kupić mając tyle
pieniędzy, ile podane w zmiennej na kieszonkowe oraz przy podanej cenie porcji. W przypadku braku
kieszonkowych na minimum jedną porcję powinien zostać wyświetlony komunikat Brak
kieszonkowych na (ulubionaPotrawa), w przeciwnym wypadku wyświetlić komunikat Możesz kupić
(ilosc) porcji (ulubionaPotrawa).
9. [Trudne] Napisać metodę ZamienRozmiar, do której będzie można przekazać rozmiar w postaci
pojedynczego znaku (S, M, L). Zadaniem metody jest zwrócenie pełnej nazwy odpowiadającej
rozmiarowi (S – Small, M – Medium, L - Large).
10. [Trudne] Wywołać utworzoną metodę, przekazując do metody wartość zmiennej rozmiar i wypisać
wynik na konsoli.
11. [Trudne] Stworzyć drugą metodę ZamienRozmiarExtra na wzór wcześniej utworzonej metody
ZamienRozmiar. Nowa metoda powinna przyjmować dwa parametry rozmiar oraz zmienną logiczną
czyRozmiarExtra. Zadanie tej metody jest takie samo jak wcześniejszej, natomiast jeżeli przekazana
wartość czyRozmiarExtra jest prawdą to dla rozmiarów S, L powinien zostać zwrócony tekst (Extra
Small, Extra Large). Zwróć uwagę, że rozmiar M nadal powinien dać wynik Medium, bez słowa Extra.
12. [Trudne] Wywołać metodę ZamienRozmiarExtra dla rozmiarów S, M, L i zweryfikować czy
wszystko działa poprawnie.
13. [Łatwe] Napisz metodę o nazwie SumaLiczb, który zwróci sumę wszystkich liczb całkowitych od 1 do n.
Na przykład SumaLiczb(5) powinno zwrócić 1 + 2 + 3 + 4 + 5 = 15.
14. [Łatwe] Napisz metodę o nazwie Silnia, który zwróci silnię liczby n.
Silnia liczby n to iloczyn wszystkich liczb całkowitych od 1 do n. Na przykład 5! = 1 * 2 * 3 * 4 * 5 = 120.
15. [Średnie] Napisz metodę o nazwie CzyLiczbaPierwsza, która zwróci true jeśli liczba n jest liczbą pierwszą, w przeciwnym wypadku false.
 Liczba pierwsza to liczba, która jest większa od 1 i ma dokładnie dwa dzielniki: 1 i samą siebie.
16. [Średnie] Napisz metodę o nazwie CzyPalindrom, która zwróci true jeśli podany napis jest palindromem, w przeciwnym wypadku false.
Palindrom to napis, który czytany od lewej do prawej i od prawej do lewej jest taki sam. Na przykład "kajak" jest palindromem.
17. [Trudne] Napisz metodę o nazwie CzyAnagram, która zwróci true jeśli podane dwa napisy są anagramami, w przeciwnym wypadku false.
 Anagram to słowo, które składa się z tych samych liter co inne słowo, ale w innej kolejności. Na przykład "kot" i "tok" są anagramami.
