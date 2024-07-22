using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projektas5
{
    internal class Ciklai
    {
        public static void Main(string[] args)
        {
            //PirmojiUzduotis();

            //AntrojiUzduotis();

            //TreciojiUzduotis();

            //KetvirtojiUzduotis();

            //PenktojiUzduotis();

            //SestojiUzduotis();

            //SeptintojiUzduotis();

            //AstuntojiUzduotis();

            //DevintojiUzduotis();

            //DesimtojiUzduotis();

            //VienuoliktojiUzduotis();

            //DvyliktojiUzduotis();

            //TryliktojiUzduotis();

            //KeturioliktojiUzduotis();

            //PenkioliktojiUzduotis();

            //SesioliktojiUzduotis();

            //SeptynioliktojiUzduotis();

            //AstuonioliktojiUzduotis();

            //DevynioliktojiUzduotis();
        }

        /// <summary>
        /// Sudeda lyginius skaicius nuo 1 iki 100 ir atspausdina rezultata
        /// </summary>
        public static void PirmojiUzduotis()
        {
            int Sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Sum += i;
            }
            Console.WriteLine($"Lyginiu skaiciu nuo 1 iki 100 suma: {Sum}");
        }

        /// <summary>
        /// Patikrina, kurie skaiciai nuo 1 iki 50 yra pirminiai
        /// </summary>
        public static void AntrojiUzduotis()
        {
            int Temp;

            Console.WriteLine("Pirminiai skaiciai nuo 1 iki 50:");
            for (int i = 1; i <= 50; i++)
            {
                Temp = 0;

                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                        Temp += i;
                }
                if (Temp == 0 && i != 1)
                    Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Apskaiciuoja, kiek skaiciu (1-100) yra dalinami is 3 arba is 5
        /// </summary>
        public static void TreciojiUzduotis()
        {
            int Amount = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Amount++;
                }
            }
            Console.WriteLine($"Skaiciu (1-100), kurie yra dalinami is 3 arba is 5, kiekis: {Amount}");
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa didziausia skaiciu jame
        /// </summary>
        public static void KetvirtojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Didziausias skaicius masyve: {TheArray[GetHighestNumberIndex(TheArray)]}");
            }
        }

        /// <summary>
        /// Nuskaito masyvo ilgi
        /// </summary>
        /// <returns></returns>
        public static int GetArrayLength()
        {
            Console.WriteLine("Iveskite sveikuju skaiciu masyvo ilgi:");
            if (!int.TryParse(Console.ReadLine(), out int ArrayLength) || ArrayLength <= 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return 0;
            }
            else
                return ArrayLength;
        }

        /// <summary>
        /// Nuskaito masyva
        /// </summary>
        /// <param name="TheArray"></param>
        public static void GetArray(ref int[] TheArray)
        {
            Console.WriteLine($"Iveskite {TheArray.Length} sveikuosius skaicius:");
            
            for(int i = 0; i < TheArray.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int Number))
                {
                    Console.WriteLine("Neteisinga ivestis, bandykite dar karta");
                    --i;
                }
                else
                    TheArray[i] = Number;
            }
        }

        /// <summary>
        /// Grazina didziausio skaiciaus indeksa masyve
        /// </summary>
        /// <param name="TheArray"></param>
        /// <returns></returns>
        public static int GetHighestNumberIndex(int[] TheArray)
        {
            int Idx = 0;

            for (int i = 1; i < TheArray.Length; i++)
            {
                if (TheArray[i] > TheArray[Idx])
                    Idx = i;
            }
            return Idx;
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir apskaiciuoja visu elementu vidurki
        /// </summary>
        public static void PenktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Visu elementu vidurkis: {GetAverage(TheArray)}");
            }
        }

        /// <summary>
        /// Grazina visu masyvo elementu vidurki
        /// </summary>
        /// <param name="TheArray"></param>
        /// <returns></returns>
        public static double GetAverage(int[] TheArray)
        {
            int Sum = 0;

            for (int i = 0; i < TheArray.Length; i++)
                Sum += TheArray[i]; 

            return Convert.ToDouble(Sum) / Convert.ToDouble(TheArray.Length);
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir suskaiciuoja neigiamus skaicius masyve
        /// </summary>
        public static void SestojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Neigiamu skaiciu kiekis: {GetNegativeCount(TheArray)}");
            }
        }

        /// <summary>
        /// Grazina neigiamu skaiciu kieki masyve
        /// </summary>
        /// <param name="TheArray"></param>
        /// <returns></returns>
        public static int GetNegativeCount(int[] TheArray)
        {
            int Count = 0;

            for (int i = 0; i < TheArray.Length; i++)
            {
                if (TheArray[i] < 0)
                    Count++;
            }

            return Count;
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir tikrina ar jame yra vartotojo ivestas skaicius
        /// </summary>
        public static void SeptintojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                CheckIfArrayContainsItem(TheArray);
            }
        }

        /// <summary>
        /// Nuskaito ieskoma skaicius ir atspausdina, ar tas skaicius yra masyve
        /// </summary>
        /// <param name="TheArray"></param>
        public static void CheckIfArrayContainsItem(int[] TheArray)
        {
            Console.WriteLine("Iveskite ieskoma skaiciu:");
            if (!int.TryParse(Console.ReadLine(), out int Number))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            else
            {
                for(int i = 0; i < TheArray.Length; i++)
                {
                    if (TheArray[i] == Number)
                    {
                        Console.WriteLine($"Skaicius {Number} yra masyve");
                        return;
                    }
                }
                Console.WriteLine($"Skaiciaus {Number} nera masyve");
            }
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva, sukuria nauja masyva atvirkstine tvarka ir ji atspausdina
        /// </summary>
        public static void AstuntojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                int[] NewArray = new int[TheArray.Length];
                MakeNewArrayInReverse(TheArray, ref NewArray);
                Console.WriteLine("Masyvas atvirkstine tvarka:");
                PrintArray(NewArray);
            }
        }

        /// <summary>
        /// Sukuria nauja masyva atvirkstine tvarka
        /// </summary>
        /// <param name="TheArray"></param>
        /// <param name="NewArray"></param>
        public static void MakeNewArrayInReverse(int[] TheArray, ref int[] NewArray)
        {
            int j = NewArray.Length - 1;
            for (int i = 0; i < TheArray.Length; i++)
            {
                if( j >= 0 )
                {
                    NewArray[j] = TheArray[i];
                    j--;
                }
            }
        }

        /// <summary>
        /// Atspausdina masyva
        /// </summary>
        /// <param name="TheArray"></param>
        public static void PrintArray(int[] TheArray)
        {
            for (int i = 0; i < TheArray.Length; i++)
            {
                Console.WriteLine(TheArray[i]);
            }
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva, randa pasikartojancius elementus ir juos atspausdina
        /// </summary>
        public static void DevintojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                FindRepeatedValues(TheArray);
            }
        }

        /// <summary>
        /// Suranda pasikartojancius elementus masyve ir juos atspausdina
        /// </summary>
        /// <param name="TheArray"></param>
        public static void FindRepeatedValues(int[] TheArray)
        {
            int[] TempArray = new int[TheArray.Length];
            int Index = -1;
            bool bSaved;

            for (int i = 0; i < TheArray.Length; i++)
            {
                for(int j = i+1; j < TheArray.Length; j++)
                {
                    if (TheArray[i] == TheArray[j])
                    {
                        bSaved = false;
                        for (int k = 0; k <= Index; k++)
                        {
                            if (TempArray[k] == TheArray[i])
                                bSaved = true;
                        }
                        if(!bSaved)
                        {
                            Index++;
                            TempArray[Index] = TheArray[i];
                        }
                    }
                }
            }
            int[] NewArray = new int[Index+1];
            for (int i = 0; i < NewArray.Length; i++)
                NewArray[i] = TempArray[i];
            Array.Sort(NewArray);
            Console.WriteLine("Pasikartojantys skaiciai:");
            PrintArray(NewArray);
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir iesko pirmo neigiamo skaiciaus
        /// </summary>
        public static void DesimtojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                FindFirstNegativeValue(TheArray);
            }
        }

        /// <summary>
        /// Iesko pirmo neigiamo skaiciaus masyve ir atspausdina rezultata
        /// </summary>
        /// <param name="TheArray"></param>
        public static void FindFirstNegativeValue(int[] TheArray)
        {
            int Index = -1;

            for (int i = 0; i < TheArray.Length; i++)
            {
                if (TheArray[i] < 0)
                {
                    Index = i;
                    break;
                }
            }
            if (Index == -1)
                Console.WriteLine("Masyve neigiamu skaiciu nera");
            else
                Console.WriteLine($"Pirmas neigiamas skaicius masyve: {TheArray[Index]}");
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir suskaiciuoja, kiek yra lyginiu ir nelyginiu skaiciu
        /// </summary>
        public static void VienuoliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                CountEvenUneven(TheArray);
            }
        }

        /// <summary>
        /// Suskaiciuoja lyginiu ir nelyginiu skaiciu kieki ir atspausdina rezultata
        /// </summary>
        /// <param name="TheArray"></param>
        public static void CountEvenUneven(int[] TheArray)
        {
            int Even = 0;
            int Uneven = 0;

            for(int i = 0; i < TheArray.Length; i++)
            {
                if (TheArray[i] % 2 == 0)
                    Even++;
                else
                    Uneven++;
            }
            Console.WriteLine($"Lyginiai: {Even}");
            Console.WriteLine($"Nelyginiai: {Uneven}");
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa didziausia ir maziausia skaicius. Rezultata atspausdina
        /// </summary>
        public static void DvyliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Didziausias skaicius: {GetArrayValue(TheArray, true)}");
                Console.WriteLine($"Maziausias skaicius: {GetArrayValue(TheArray, false)}");
            }
        }

        /// <summary>
        /// Grazina didziausia arba maziausia skaiciu masyve, priklausomai nuo bMax kintamojo
        /// </summary>
        /// <param name="TheArray"></param>
        /// <param name="bMax"></param>
        /// <returns></returns>
        public static int GetArrayValue(int[] TheArray, bool bMax)
        {
            int i = 1;
            int Index = 0;
            
            while(i < TheArray.Length)
            {
                if (bMax && TheArray[i] > TheArray[Index])
                    Index = i;
                else if (!bMax && TheArray[i] < TheArray[Index])
                    Index = i;
                i++;
            }
            return TheArray[Index];
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir suskaiciuoja suma visu elementu, kurie patenka i vartotojo nurodyta rezi
        /// </summary>
        public static void TryliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                CountSumInUserDefinedRange(TheArray);
            }
        }

        /// <summary>
        /// Suskaiciuoja ir atspausdina elementu, kurie patenka i nurodyta rezi, suma
        /// </summary>
        /// <param name="TheArray"></param>
        public static void CountSumInUserDefinedRange(int[] TheArray)
        {
            int Sum = 0;

            Console.WriteLine("Iveskite sumos rezio pradzia:");
            if (!int.TryParse(Console.ReadLine(), out int SumStart))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }

            Console.WriteLine("Iveskite sumos rezio pabaiga:");
            if (!int.TryParse(Console.ReadLine(), out int SumEnd))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }

            if (SumStart > SumEnd)
            {
                Sum = SumEnd;
                SumEnd = SumStart;
                SumStart = Sum;
                Sum = 0;
            }

            for (int i = 0; i < TheArray.Length; i++)
            {
                if (TheArray[i] >= SumStart && TheArray[i] <= SumEnd)
                    Sum += TheArray[i];
            }
            Console.WriteLine($"Masyvo elementu suma tarp nurodytu reziu: {Sum}");
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa ilgiausia didejancia seka jame
        /// </summary>
        public static void KeturioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                FindLongestSequence(TheArray);
            }
        }

        /// <summary>
        /// Randa ilgiausia didejancia skaiciu seka masyve ir ji atspausdina
        /// </summary>
        /// <param name="TheArray"></param>
        public static void FindLongestSequence(int[] TheArray)
        {
            int TempMinIdx = 0;
            int TempMaxIdx = 0;
            int MaxIdx = 0;
            int MinIdx = 0;
            int i = 1;

            while (i < TheArray.Length)
            {
                if (TheArray[i] <= TheArray[i - 1])
                    TempMinIdx = i;
                TempMaxIdx = i;
                if (TempMaxIdx - TempMinIdx >= MaxIdx - MinIdx)
                {
                    MaxIdx = TempMaxIdx;
                    MinIdx = TempMinIdx;
                }
                i++;
            }

            int[] NewArray = new int[1+MaxIdx-MinIdx];
            i = 0;
            while(i < NewArray.Length)
            {
                NewArray[i] = TheArray[MinIdx + i];
                i++;
            }
            Console.WriteLine("Ilgiausia sio masyvo didejanti seka:");
            PrintArray(NewArray);
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa visas elementu poras, kuriu suma yra lygine
        /// </summary>
        public static void PenkioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                FindEvenPairs(TheArray);
            }
        }

        /// <summary>
        /// Suranda masyvo elementu poras, kurios yra lygines ir jas atspausdina
        /// </summary>
        /// <param name="TheArray"></param>
        public static void FindEvenPairs(int[] TheArray)
        {
            for(int i = 0; i < TheArray.Length; i++)
            {
                for(int j = i + 1; j < TheArray.Length; j++)
                {
                    if ((TheArray[i] + TheArray[j]) % 2 == 0)
                        Console.WriteLine($"Lygine pora: {TheArray[i]}, {TheArray[j]}");
                }
            }
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir apsuka dali masyvo pagal vartotojo nurodytus indeksus
        /// </summary>
        public static void SesioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                EditArrayOrder(TheArray);
            }
        }

        /// <summary>
        /// Nuskaito vartotojo indeksus ir pagal tai apkeicia vietomis masyvo elementus. Rezultata atspausdina
        /// </summary>
        /// <param name="TheArray"></param>
        public static void EditArrayOrder(int[] TheArray)
        {
            int[] NewArray = new int[TheArray.Length];
            int Temp;

            Console.WriteLine("Iveskite pradini indeksa:");
            if (!int.TryParse(Console.ReadLine(), out int IdxStart) || IdxStart < 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            else if (IdxStart >= TheArray.Length)
            {
                Console.WriteLine("Virsytas masyvo ilgis!");
                return;
            }

            Console.WriteLine("Iveskite galutini indeksa:");
            if (!int.TryParse(Console.ReadLine(), out int IdxEnd) || IdxEnd < 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            else if (IdxEnd >= TheArray.Length)
            {
                Console.WriteLine("Virsytas masyvo ilgis!");
                return;
            }

            if(IdxStart == IdxEnd)
            {
                Console.WriteLine("Nurodytas tas pats indeksas!");
                return;
            }
            else if(IdxStart > IdxEnd)
            {
                Temp = IdxEnd;
                IdxEnd = IdxStart;
                IdxStart = Temp;
            }

            int i = 0;
            while (i < TheArray.Length)
            {
                if(i >= IdxStart && i <= IdxEnd)
                    NewArray[i] = TheArray[IdxEnd - (i - IdxStart)];
                else
                    NewArray[i] = TheArray[i];
                i++;
            }
            Console.WriteLine("Pertvarkytas masyvas:");
            PrintArray(NewArray);
        }


        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa antra maziausia skaiciu
        /// </summary>
        public static void SeptynioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Antras maziausias skaicius: {FindSecondLowest(TheArray)}");
            }
        }

        /// <summary>
        /// Grazina antra maziausia skaiciu masyve
        /// </summary>
        /// <param name="TheArray"></param>
        /// <returns></returns>
        public static int FindSecondLowest(int[] TheArray)
        {
            if (TheArray.Length == 1)
                return TheArray[0];

            int Min;
            int TempMin;

            if( TheArray[0] < TheArray[1] )
            {
                Min = TheArray[0];
                TempMin = TheArray[1];
            }
            else
            {
                TempMin = TheArray[0];
                Min = TheArray[1];
            }

            for (int i = 2; i < TheArray.Length; i++)
            {
                if(TheArray[i] < Min)
                {
                    TempMin = Min;
                    Min = TheArray[i];
                }
                else if(TheArray[i] < TempMin)
                {
                    TempMin = TheArray[i];
                }
            }
            return TempMin;
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa dazniausiai pasikartojanti skaiciu
        /// </summary>
        public static void AstuonioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                Console.WriteLine($"Dazniausiai pasikartojantis skaicius: {FindMostFrequent(TheArray)}");
            }
        }

        /// <summary>
        /// Grazina dazniausiai pasikartojanti skaiciu masyve
        /// </summary>
        /// <param name="TheArray"></param>
        /// <returns></returns>
        public static int FindMostFrequent(int[] TheArray)
        {
            int[] Value = new int[TheArray.Length];
            int[] Count = new int[TheArray.Length];
            int IdxUsed = 0;
            int TempIdx = 0;
            bool bFound;

            int i = 0;
            while(i < TheArray.Length)
            {
                bFound = false;
                int j = 0;
                while (j < IdxUsed)
                {
                    if (Value[j] == TheArray[i])
                    {
                        Count[j] += 1;
                        bFound = true;
                        break;
                    }
                    j++;
                }
                if(!bFound)
                {
                    Value[IdxUsed] = TheArray[i];
                    Count[IdxUsed] += 1;
                    IdxUsed += 1;
                }
                i++;
            }
            TempIdx = 0;
            i = 0;
            while (i < IdxUsed)
            {
                if (Count[i] > Count[TempIdx])
                    TempIdx = i;
                i++;
            }
            return Value[TempIdx];
        }

        /// <summary>
        /// Nuskaito sveikuju skaiciu masyva ir randa unikalius elementus
        /// </summary>
        public static void DevynioliktojiUzduotis()
        {
            int ArrayLength = GetArrayLength();
            if (ArrayLength > 0)
            {
                int[] TheArray = new int[ArrayLength];
                GetArray(ref TheArray);
                FindUniqueItems(TheArray);
            }
        }

        /// <summary>
        /// Randa unikalius elementus ir juos atspausdina
        /// </summary>
        /// <param name="TheArray"></param>
        public static void FindUniqueItems(int[] TheArray)
        {
            int[] NewArray = new int[TheArray.Length];
            int NewArrayLength = 0;
            bool bUnique;

            for(int i = 0; i < TheArray.Length; i++)
            {
                bUnique = true;
                for (int j = 0; j < TheArray.Length; j++ )
                {
                    if(i != j && TheArray[i] == TheArray[j])
                        bUnique = false;
                }
                if(bUnique)
                {
                    NewArray[NewArrayLength] = TheArray[i];
                    NewArrayLength++;
                }
            }
            if(NewArrayLength == 0)
                Console.WriteLine("Unikaliu elementu nera");
            else
            {
                Console.WriteLine("Unikalus masyvo elementai:");
                if (NewArrayLength != NewArray.Length)
                {
                    int[] NewArray2 = new int[NewArrayLength];
                    for (int i = 0; i < NewArray2.Length; i++)
                        NewArray2[i] = NewArray[i];
                    PrintArray(NewArray2);
                }
                else
                    PrintArray(NewArray);
            }
        }
    }
}
