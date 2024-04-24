// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

int x = 5;
var i = 1;

var ii = -1; //Bu değişken, bilmem ne değerini takip eder.

var d = 0; //Müşterinin kayıt olduğu tarihten bu yana geçen gün sayısı

//1. Anlamlı isim kullanın!
var daysSinceCustomerCreated = 180;
int musterinKayıtOldugundanBeriGecenGun = 250;

//bool banuAlkan = false;
//2. kısaltmadan kaçının (mecbur olmadıkça kullanmayın)

var hpLaptopCount = 0;
/*
 * HP Bilgisayar
 * Hit Point
 * Horse Power
 * Health Point
 *  
 */
//3. Değişken adı, veri tipiyle uyumlu olsun
int intNumber = 8;
int number = 8;
bool isApproved = false;
bool isDone = false;

//Kompleks tipler, değişken adı içerisinde geçsin: 
DataTable customersDataTable = new DataTable();
Random randomNumberGenerator = new Random();

var emailList = new List<string>();
var emails = new List<string>();


//4. Benzer semboller kullanmayın!
var o = 0;
var l = 1;

if (o == 1)
{
    o = l;
}

string passwordSample = "Pa$$w0rd1";

bool isIncludeLetter = true;
bool isIncludeNumber = true;
bool isIncludeSymbol = true;

bool isSecurePassword = isIncludeLetter && isIncludeNumber && isIncludeSymbol;
if (isSecurePassword)
{

}

List<int[]> cellsOnABoard = new List<int[]>();
List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();

    foreach (var cell in cellsOnABoard)
    {
        if (cell[0] == (int)CellType.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }

    return flaggedCells;
}


public enum CellType
{
    Normal=1,
    Flagged = 4,
    Exploded = 6
}












