// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
/*
 * 1. Birim zamanda sadece bir iş yapmalıdır!
 * 2. Mümkün olduğu kadar az parametresi olmalı!
 * 3. Gövde konu en az satırdan oluşan fonksiyon en temiz fonksiyondur!
 * 
 *  DRY: Don't repeat yourself: Kendini tekrar etme!
 *  
 */

/*
 *  1. Rastgeleme kelime listesinin içinden bir kelime seç.
 *  2. Bu kelimenin her bir karakterini * işaretine dönüştür.
 *  3. Ekranda bulmacayı göster.
 *  4. Kullanıcıdan harf girmesini iste.
 *  5. Harfin kelimede olup olmadığına bak
 *  6. Varsa, o harfin bulunduğu * işaretlerini harfle değiştir. Yoksa harf hakkından bir düş.
 *   
 *  
 */

string getRandomWord(List<string> words)
{
    return "ayna";
}

string getPuzzledWord(string input) 
{
    return "****";
}
void showPuzzledWord(string puzzledWord) => Console.WriteLine(puzzledWord);
string getLetterFromUser() { return "a"; }

bool puzzleIsIncludeLetter(string word, string letter)=> word.Contains(letter);
string replacePuzzleWithLetter(string word, string letter) => "a**a";

/*
 *  1. Rastgeleme kelime listesinin içinden bir kelime seç.
 *  2. Bu kelimenin her bir karakterini * işaretine dönüştür.
 *  3. Ekranda bulmacayı göster.
 *  4. Kullanıcıdan harf girmesini iste.
 *  5. Harfin kelimede olup olmadığına bak
 *  6. Varsa, o harfin bulunduğu * işaretlerini harfle değiştir. Yoksa harf hakkından bir düş.
 *   
 *  
 */

var selectedWord = getRandomWord(new List<string>());
var puzzled = getPuzzledWord(selectedWord);
showPuzzledWord(puzzled);
var letter = getLetterFromUser();
var isInclude = puzzleIsIncludeLetter(selectedWord, letter);
if (isInclude)
{
    puzzled = replacePuzzleWithLetter(selectedWord, letter);
}
else
{

}
var number = 8;

string message = number % 2 == 0 ? "Çift" : "Tek";

//if (number % 2 == 0)
//{
//    message = "Çift";
//}
//else
//{
//    message = "Tek";
//}

Random random = new Random();
ReportGenerator reportGenerator = new ReportGenerator("C:\\abc.xlsx");
reportGenerator.Create("C:\\abc.pdf");



