using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeTest
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.WriteLine("DEV-BLOCK - Variable tutorial");
 
            //SByte 
            Console.WriteLine("****************************************************");
            Console.WriteLine("sbyte");
            Console.WriteLine("sbyte Max Value: " + sbyte.MaxValue);
            Console.WriteLine("sbyte Min Value: " + sbyte.MinValue);
            Console.WriteLine("sbyte Size in bits: " + sizeof(sbyte)*8);
            Console.WriteLine("C#: sbyte SByteVar = 10;");
          
            sbyte SByteVar = 10;

            Console.WriteLine("Type of SByteVar: " + SByteVar.GetType());
            Console.WriteLine("SByteVar value: " + SByteVar);
            Console.WriteLine("SByte binary: " + Convert.ToString(SByteVar, 2).PadLeft(sizeof(sbyte) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //Byte 
            Console.WriteLine("****************************************************");
            Console.WriteLine("byte");
            Console.WriteLine("byte Max Value: " + byte.MaxValue);
            Console.WriteLine("byte Min Value: " + byte.MinValue);
            Console.WriteLine("byte Size in bits: " + sizeof(byte) * 8);
            Console.WriteLine("C#: byte ByteVar = 110;");

            byte ByteVar = 110;

            Console.WriteLine("Type of ByteVar: " + ByteVar.GetType());
            Console.WriteLine("ByteVar value: " + ByteVar);
            Console.WriteLine("byte binary: " + Convert.ToString(ByteVar, 2).PadLeft(sizeof(byte) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //Short
            Console.WriteLine("****************************************************");
            Console.WriteLine("Short");
            Console.WriteLine("Short Max Value: " + short.MaxValue);
            Console.WriteLine("Short Min Value: " + short.MinValue);
            Console.WriteLine("short Size in bits: " + sizeof(short) * 8);
            Console.WriteLine("C#: short shortVar = 1450;");

            short shortVar = 1450;

            Console.WriteLine("Type of shortVar: " + shortVar.GetType());
            Console.WriteLine("shortVar value: " + shortVar);
            Console.WriteLine("short binary: " + Convert.ToString(shortVar, 2).PadLeft(sizeof(short) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();


            //Ushort
            Console.WriteLine("****************************************************");
            Console.WriteLine("ushort");
            Console.WriteLine("ushort Max Value: " + ushort.MaxValue);
            Console.WriteLine("ushort Min Value: " + ushort.MinValue);
            Console.WriteLine("ushort Size in bits: " + sizeof(ushort) * 8);
            Console.WriteLine("C#: ushort ushortVar = 1470;");

            ushort ushortVar = 1470;

            Console.WriteLine("Type of ushortVar: " + ushortVar.GetType());
            Console.WriteLine("ushortVar value: " + ushortVar);
            Console.WriteLine("ushort binary: " + Convert.ToString(ushortVar, 2).PadLeft(sizeof(ushort) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //int
            Console.WriteLine("****************************************************");
            Console.WriteLine("int");
            Console.WriteLine("int Max Value: " + int.MaxValue);
            Console.WriteLine("int Min Value: " + int.MinValue);
            Console.WriteLine("int Size in bits: " + sizeof(int) * 8);
            Console.WriteLine("C#: int intVar = 2511450;");

            int intVar = 2511450;

            Console.WriteLine("Type of intVar: " + intVar.GetType());
            Console.WriteLine("intVar value: " + intVar);
            Console.WriteLine("int binary: " + Convert.ToString(intVar, 2).PadLeft(sizeof(int) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();


            //uint
            Console.WriteLine("****************************************************");
            Console.WriteLine("uint");
            Console.WriteLine("uint Max Value: " + uint.MaxValue);
            Console.WriteLine("uint Min Value: " + uint.MinValue);
            Console.WriteLine("uint Size in bits: " + sizeof(uint) * 8);
            Console.WriteLine("C#: uint uintVar = 2511454;");

            uint uintVar = 2511454;

            Console.WriteLine("Type of uintVar: " + uintVar.GetType());
            Console.WriteLine("uintVar value: " + uintVar);
            Console.WriteLine("uint binary: " + Convert.ToString(uintVar, 2).PadLeft(sizeof(uint) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //long
            Console.WriteLine("****************************************************");
            Console.WriteLine("long");
            Console.WriteLine("long Max Value: " + long.MaxValue);
            Console.WriteLine("long Min Value: " + long.MinValue);
            Console.WriteLine("long Size in bits: " + sizeof(long) * 8);
            Console.WriteLine("C#: long longVar = 251451454;");
            long longVar = 251451454;
            Console.WriteLine("Type of longVar: " + longVar.GetType());
            Console.WriteLine("longVar value: " + longVar);
            Console.WriteLine("long binary: " + Convert.ToString(longVar, 2).PadLeft(sizeof(long) * 8, '0'));
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //ulong
            Console.WriteLine("****************************************************");
            Console.WriteLine("ulong");
            Console.WriteLine("ulong Max Value: " + ulong.MaxValue);
            Console.WriteLine("ulong Min Value: " + ulong.MinValue);
            Console.WriteLine("ulong Size in bits: " + sizeof(ulong) * 8);
            Console.WriteLine("C#: ulong ulongVar = 251451454;");

            ulong ulongVar = 251451454;

            Console.WriteLine("Type of ulongVar: " + ulongVar.GetType());
            Console.WriteLine("ulongVar value: " + ulongVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //float
            //7 Significant Figures
            Console.WriteLine("****************************************************");
            Console.WriteLine("float");
            Console.WriteLine("float Max Value: " + float.MaxValue);
            Console.WriteLine("float Max Value as Number: " + float.MaxValue.ToString("N"));
            Console.WriteLine("float Min Value: " + float.MinValue);
            Console.WriteLine("float Min Value as Number: " + float.MinValue.ToString("N"));
            Console.WriteLine("float Size in bits: " + sizeof(float) * 8);
            Console.WriteLine("C#: float floatVar = 251451454f;");

            float floatVar = 251451454f;

            Console.WriteLine("Type of floatVar: " + floatVar.GetType());
            Console.WriteLine("floatVar value: " + floatVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //double
            //15 Significant Figures
            Console.WriteLine("****************************************************");
            Console.WriteLine("double");
            Console.WriteLine("double Max Value: " + double.MaxValue);
            Console.WriteLine("double Max Value as Number: " + double.MaxValue.ToString("N"));
            Console.WriteLine("double Min Value: " + double.MinValue);
            Console.WriteLine("double Min Value as Number: " + double.MinValue.ToString("N"));
            Console.WriteLine("double Size in bits: " + sizeof(double) * 8);
            Console.WriteLine("C#: double doubleVar = 0.1234567890123456d;");

            double doubleVar = 0.1234567890123456d;

            Console.WriteLine("Type of doubleVar: " + doubleVar.GetType());
            Console.WriteLine("doubleVar value: " + doubleVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();


            //decimal
            //28 Significant Figures
            Console.WriteLine("****************************************************");
            Console.WriteLine("decimal");
            Console.WriteLine("decimal Max Value: " + decimal.MaxValue);
            Console.WriteLine("decimal Max Value as Number: " + decimal.MaxValue.ToString("N"));
            Console.WriteLine("decimal Min Value: " + decimal.MinValue);
            Console.WriteLine("decimal Min Value as Number: " + decimal.MinValue.ToString("N"));
            Console.WriteLine("decimal Size in bits: " + sizeof(decimal) * 8);
            Console.WriteLine("C#: decimal decimalVar = 0.1234567890123456789012345678m;");

            decimal decimalVar = 0.1234567890123456789012345678m;

            Console.WriteLine("Type of decimalVar: " + decimalVar.GetType());
            Console.WriteLine("decimalVar value: " + decimalVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //bool
            //28 Significant Figures
            Console.WriteLine("****************************************************");
            Console.WriteLine("bool");
            Console.WriteLine("bool Value: " + bool.TrueString);
            Console.WriteLine("bool Value: " + bool.FalseString);
            Console.WriteLine("bool Size in bits: " + sizeof(bool) * 8);
            Console.WriteLine("C#: bool boolVar = true");

            bool boolVar = true;

            Console.WriteLine("Type of boolVar: " + boolVar.GetType());
            Console.WriteLine("boolVar value: " + boolVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();



            //Char
            //16 Bit Unicode Character
            Console.WriteLine("****************************************************");
            Console.WriteLine("char");
            Console.WriteLine("char Value: " + char.MaxValue);
            Console.WriteLine("char Value: " + char.MinValue);
            Console.WriteLine("char Size in bits: " + sizeof(char) * 8);
            Console.WriteLine("C#: char charVar = 'A'");

            char charVar = 'A';

            Console.WriteLine("Type of charVar: " + charVar.GetType());
            Console.WriteLine("charVar value: " + charVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();


            //String
            Console.WriteLine("****************************************************");
            Console.WriteLine("C#: string stringVar = \"Hello World\";");

            string stringVar = "Hello World";

            Console.WriteLine("Type of stringVar: " + stringVar.GetType());
            Console.WriteLine("stringVar value: " + stringVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();

            //Object
            Console.WriteLine("****************************************************");
            Console.WriteLine("C#:  object objectVar = new object();");

            object objectVar = new object();

            Console.WriteLine(objectVar.ToString());
            Console.WriteLine("C#:   object objectIntVar = 48f;");

            object objectIntVar = 48f;

            Console.WriteLine("Get Type of objectIntVar: " + objectIntVar.GetType());
            Console.WriteLine("Value in objectIntVar: " + (Single)objectIntVar);
            Console.WriteLine("****************************************************");
            Console.ReadKey();

        }
    }
}
