using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Switch
{
    public static class SwitchCase
    {
        public static void Main(String[] bea)
        {
            
            
                string choice;
                Console.WriteLine("\t========================================================================");
                Console.WriteLine("");
                Console.WriteLine("\t░░░░░░░ ░░      ░░░░░░░ ░░░    ░░░ ░░░░░░░ ░░░    ░░ ░░░░░░░░  ░░░░░░  \r\n\t▒▒      ▒▒      ▒▒      ▒▒▒▒  ▒▒▒▒ ▒▒      ▒▒▒▒   ▒▒    ▒▒    ▒▒    ▒▒ \r\n\t▒▒▒▒▒   ▒▒      ▒▒▒▒▒   ▒▒ ▒▒▒▒ ▒▒ ▒▒▒▒▒   ▒▒ ▒▒  ▒▒    ▒▒    ▒▒    ▒▒ \r\n\t▓▓      ▓▓      ▓▓      ▓▓  ▓▓  ▓▓ ▓▓      ▓▓  ▓▓ ▓▓    ▓▓    ▓▓    ▓▓ \r\n\t███████ ███████ ███████ ██      ██ ███████ ██   ████    ██     ██████  \r");
                Console.WriteLine("");
                Console.WriteLine("\t========================================================================");
                Console.WriteLine("\t| | \t                Welcome to the Main Menu!                    | |");
                Console.WriteLine("\t| | \t                                                             | |");
                Console.WriteLine("\t| | \t [A] Details                                                 | |");
                Console.WriteLine("\t| | \t [B] Group of Elements                                       | |");
                Console.WriteLine("\t| | \t [C] Trivia                                                  | |");
                Console.WriteLine("\t| | \t [D] Natural Occurences                                      | |");
                Console.WriteLine("\t| | \t                                                             | |");
                Console.WriteLine("\t| | \t [E] Exit                                                    | |");
                Console.WriteLine("\t| | \t                                                             | |");
                Console.WriteLine("\t========================================================================");


            Console.WriteLine();
            Console.WriteLine("\t\t**In capital letters only**");
            Console.WriteLine();
            Console.Write("\t\tEnter your choice: ");
            choice = Console.ReadLine();
            
         

            Console.Clear();

            if (choice == "A")
            {
                Console.WriteLine("\t==================================================================\n");
                Console.WriteLine("\t\t██████╗ ███████╗████████╗ █████╗ ██╗██╗     ███████╗\r\n\t\t██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║██║     ██╔════╝\r\n\t\t██║  ██║█████╗     ██║   ███████║██║██║     ███████╗\r\n\t\t██║  ██║██╔══╝     ██║   ██╔══██║██║██║     ╚════██║\r\n\t\t██████╔╝███████╗   ██║   ██║  ██║██║███████╗███████║");
                Console.WriteLine("\n\t==================================================================");
                Console.WriteLine("\t| | \t                                                       ");
                Console.WriteLine("\t| | \t                                                       ");
                Console.Write("\t| | \tEnter the Atomic Number: ");               
                int anVer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t| | \t                                                       ");
                Console.WriteLine("\t| | \t                                                       ");


                Console.WriteLine(" ")

                switch (anVer)
                {

                    //atomin number switch case
                    //symbol ex H
                    //Name ex hydrogen
                    //ave atomic mass ex 195.1
                    // slash mf nsa consol.write
                
                    case 1:
                        Console.WriteLine("\t| | \tSymbol: H \n\t| |\tName: Hydrogen \n\t| |\tAtomic weight: 1.0078 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 2:
                        Console.WriteLine("\t| | \tSymbol: He \n\t| |\tName: Helium \n\t| |\tAtomic weight: 4.0 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 3:
                        Console.WriteLine("\t| | \tSymbol: Li \n\t| |\tName: Lithium \n\t| |\tAtomic weight: 6.9 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 4:
                        Console.WriteLine("\t| | \tSymbol: Be \n\t| |\tName: Beryllium \n\t| |\tAtomic weight: 9.01218 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 5:
                        Console.WriteLine("\t| | \tSymbol: B \n\t| |\tName: Boron \n\t| |\tAtomic weight: 10.81 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 6:
                        Console.WriteLine("\t| | \tSymbol: C \n\t| |\tName: Carbon \n\t| |\tAtomic weight: 12.011 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 7:
                        Console.WriteLine("\t| | \tSymbol: N \n\t| |\tName: Nitrogen \n\t| |\tAtomic weight: 14.0067 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 8:
                        Console.WriteLine("\t| | \tSymbol: O \n\t| |\tName: Oxygen \n\t| |\tAtomic weight: 15.9994 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 9:
                        Console.WriteLine("\t| | \tSymbol: F \n\t| |\tName: Fluorine \n\t| |\tAtomic weight: 18.998403 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 10:
                        Console.WriteLine("\t| | \tSymbol: Ne \n\t| |\tName: Neon \n\t| |\tAtomic weight: 20.179 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 11:
                        Console.WriteLine("\t| | \tSymbol: Na \n\t| |\tName: Sodium \n\t| |\tAtomic weight: 22.98977 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 12:
                        Console.WriteLine("\t| | \tSymbol: Mg \n\t| |\tName: Magnesium \n\t| |\tAtomic weight: 24.305 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 13:
                        Console.WriteLine("\t| | \tSymbol: Al \n\t| |\tName: Aluminum \n\t| |\tAtomic weight: 26.98154 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 14:
                        Console.WriteLine("\t| | \tSymbol: Si \n\t| |\tName: Silicon \n\t| |\tAtomic weight: 28.0855 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 15:
                        Console.WriteLine("\t| | \tSymbol: P \n\t| |\tName: Phosporus \n\t| |\tAtomic weight: 30.97376 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 16:
                        Console.WriteLine("\t| | \tSymbol: S \n\t| |\tName: Sulfur \n\t| |\tAtomic weight: 32.06 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 17:
                        Console.WriteLine("\t| | \tSymbol: Cl \n\t| |\tName: Chlorine \n\t| |\tAtomic weight: 35.453 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 18:
                        Console.WriteLine("\t| | \tSymbol: Ar \n\t| |\tName: Argon \n\t| |\tAtomic weight: 39.948 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 19:
                        Console.WriteLine("\t| | \tSymbol: K \n\t| |\tName: Potassium \n\t| |\tAtomic weight: 39.0983 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 20:
                        Console.WriteLine("\t| | \tSymbol: Ca \n\t| |\tName: Calcium \n\t| |\tAtomic weight: 40.08 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 21:
                        Console.WriteLine("\t| | \tSymbol: Sc \n\t| |\tName: Scandium \n\t| |\tAtomic weight: 44.9559 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 22:
                        Console.WriteLine("\t| | \tSymbol: Ti \n\t| |\tName: Titanium \n\t| |\tAtomic weight: 47.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 23:
                        Console.WriteLine("\t| | \tSymbol: V \n\t| |\tName: Vanadium \n\t| |\tAtomic weight: 50.9415 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 24:
                        Console.WriteLine("\t| | \tSymbol: Cr \n\t| |\tName: Chronium \n\t| |\tAtomic weight: 51.996 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 25:
                        Console.WriteLine("\t| | \tSymbol: Mn \n\t| |\tName: Manganese \n\t| |\tAtomic weight: 54.9380 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 26:
                        Console.WriteLine("\t| | \tSymbol: Fe \n\t| |\tName: Iron \n\t| |\tAtomic weight: 55.847 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 27:
                        Console.WriteLine("\t| | \tSymbol: Co \n\t| |\tName: Cobalt \n\t| |\tAtomic weight: 58.9332 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 28:
                        Console.WriteLine("\t| | \tSymbol: Ni \n\t| |\tName: Nickel \n\t| |\tAtomic weight: 58.70 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 29:
                        Console.WriteLine("\t| | \tSymbol: Cu \n\t| |\tName: Copper \n\t| |\tAtomic weight: 63.546 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 30:
                        Console.WriteLine("\t| | \tSymbol: Zn \n\t| |\tName: Zinc \n\t| |\tAtomic weight: 65.38 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 31:
                        Console.WriteLine("\t| | \tSymbol: Ga \n\t| |\tName: Gallium \n\t| |\tAtomic weight: 69.72 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 32:
                        Console.WriteLine("\t| | \tSymbol: Ge \n\t| |\tName: Germanium \n\t| |\tAtomic weight: 72.59 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 33:
                        Console.WriteLine("\t| | \tSymbol: As \n\t| |\tName: Arsenic \n\t| |\tAtomic weight: 74.9216 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 34:
                        Console.WriteLine("\t| | \tSymbol: Se \n\t| |\tName: Selenium \n\t| |\tAtomic weight: 78.96 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 35:
                        Console.WriteLine("\t| | \tSymbol: Br \n\t| |\tName: Bromine \n\t| |\tAtomic weight: 79.904 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 36:
                        Console.WriteLine("\t| | \tSymbol: Kr \n\t| |\tName: Krypton \n\t| |\tAtomic weight: 83.80 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 37:
                        Console.WriteLine("\t| | \tSymbol: Rb \n\t| |\tName: Rubidium \n\t| |\tAtomic weight: 85.4678 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 38:
                        Console.WriteLine("\t| | \tSymbol: Sr \n\t| |\tName: Strontium \n\t| |\tAtomic weight: 87.62 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 39:
                        Console.WriteLine("\t| | \tSymbol: Y \n\t| |\tName: Yttrium \n\t| |\tAtomic weight: 88.9059 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 40:
                        Console.WriteLine("\t| | \tSymbol: Zr \n\t| |\tName: Zirconium \n\t| |\tAtomic weight: 91.22 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 41:
                        Console.WriteLine("\t| | \tSymbol: Nb \n\t| |\tName: Niobium \n\t| |\tAtomic weight: 92.9064 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 42:
                        Console.WriteLine("\t| | \tSymbol: Mo \n\t| |\tName: Molybdenum \n\t| |\tAtomic weight: 95.94 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 43:
                        Console.WriteLine("\t| | \tSymbol: Tc \n\t| |\tName: Technetium \n\t| |\tAtomic weight: 98 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 44:
                        Console.WriteLine("\t| | \tSymbol: Ru \n\t| |\tName: Ruthenium \n\t| |\tAtomic weight: 101.07 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 45:
                        Console.WriteLine("\t| | \tSymbol: Rh \n\t| |\tName: Rhodium \n\t| |\tAtomic weight: 102.9055 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 46:
                        Console.WriteLine("\t| | \tSymbol: Pd \n\t| |\tName: Palladium \n\t| |\tAtomic weight: 106.4 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 47:
                        Console.WriteLine("\t| | \tSymbol: Ag \n\t| |\tName: Silver \n\t| |\tAtomic weight: 107.868 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 48:
                        Console.WriteLine("\t| | \tSymbol: Cd \n\t| |\tName: Cadmium \n\t| |\tAtomic weight: 112.41 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 49:
                        Console.WriteLine("\t| | \tSymbol: In \n\t| |\tName: Indium \n\t| |\tAtomic weight: 114.82 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 50:
                        Console.WriteLine("\t| | \tSymbol: Sn \n\t| |\tName: Tin \n\t| |\tAtomic weight: 118.69 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 51:
                        Console.WriteLine("\t| | \tSymbol: Sb \n\t| |\tName: Antimony \n\t| |\tAtomic weight: 121.75 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;


                    case 52:
                        Console.WriteLine("\t| | \tSymbol: Te \n\t| |\tName: Tellurium \n\t| |\tAtomic weight: 127.60 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 53:
                        Console.WriteLine("\t| | \tSymbol: I \n\t| |\tName: Iodine \n\t| |\tAtomic weight: 126.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 54:
                        Console.WriteLine("\t| | \tSymbol: Xe \n\t| |\tName: Xenon \n\t| |\tAtomic weight: 131.30 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 55:
                        Console.WriteLine("\t| | \tSymbol: Cs \n\t| |\tName: Cesium \n\t| |\tAtomic weight: 132.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 56:
                        Console.WriteLine("\t| | \tSymbol: Ba \n\t| |\tName: Barium \n\t| |\tAtomic weight: 137.33 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 57:
                        Console.WriteLine("\t| | \tSymbol: La \n\t| |\tName: Lanthanium \n\t| |\tAtomic weight: 138.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 58:
                        Console.WriteLine("\t| | \tSymbol: Ce \n\t| |\tName: Cerium \n\t| |\tAtomic weight: 140.12 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 59:
                        Console.WriteLine("\t| | \tSymbol: Pr \n\t| |\tName: Praseodymium \n\t| |\tAtomic weight: 140.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;
                       
                    case 60:
                        Console.WriteLine("\t| | \tSymbol: Nd \n\t| |\tName: Neodymium \n\t| |\tAtomic weight: 144.24 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 61:
                        Console.WriteLine("\t| | \tSymbol:\"Pm \n\t| |\tName: Cesium \n\t| |\tAtomic weight:  132.90 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 62:
                        Console.WriteLine("\t| | \tSymbol: Sm \n\t| |\tName: Samarium \n\t| |\tAtomic weight: 150.4 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 63:
                        Console.WriteLine("\t| | \tSymbol: Eu \n\t| |\tName: Europium \n\t| |\tAtomic weight: 151.96 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 64:
                        Console.WriteLine("\t| | \tSymbol: Gd \n\t| |\tName: Gadolnium \n\t| |\tAtomic weight: 157.25 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 65:
                        Console.WriteLine("\t| | \tSymbol: Tb \n\t| |\tName: Terbium \n\t| |\tAtomic weight: 158.93 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 66:
                        Console.WriteLine("\t| | \tSymbol: Dy \n\t| |\tName: Dysprosium \n\t| |\tAtomic weight: 162.50 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 67:
                        Console.WriteLine("\t| | \tSymbol: Ho \n\t| |\tName: Holmium \n\t| |\tAtomic weight: 164.93 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 68:
                        Console.WriteLine("\t| | \tSymbol: Er \n\t| |\tName: Erbium \n\t| |\tAtomic weight: 167.26 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 69:
                        Console.WriteLine("\t| | \tSymbol: Tm \n\t| |\tName: Thulium \n\t| |\tAtomic weight: 168.93 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 70:
                        Console.WriteLine("\t| | \tSymbol: Yb \n\t| |\tName: Ytterbium \n\t| |\tAtomic weight: 173.04 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 71:
                        Console.WriteLine("\t| | \tSymbol: Lu \n\t| |\tName: Lutetium \n\t| |\tAtomic weight: 174.98 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 72:
                        Console.WriteLine("\t| | \tSymbol: Hf \n\t| |\tName: Hafnium \n\t| |\tAtomic weight: 178.49 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 73:
                        Console.WriteLine("\t| | \tSymbol: Ta \n\t| |\tName: Tantalum \n\t| |\tAtomic weight: 180.85 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 74:
                        Console.WriteLine("\t| | \tSymbol: W \n\t| |\tName: Tungsten \n\t| |\tAtomic weight: 183.85 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 75:
                        Console.WriteLine("\t| | \tSymbol: Re \n\t| |\tName: Tungsten \n\t| |\tAtomic weight: 183.85 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 76:
                        Console.WriteLine("\t| | \tSymbol: Os \n\t| |\tName: Osmium \n\t| |\tAtomic weight: 190.2 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 77:
                        Console.WriteLine("\t| | \tSymbol: Ir \n\t| |\tName: Iridium \n\t| |\tAtomic weight: 192.22 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 78:
                        Console.WriteLine("\t| | \tSymbol: Pt \n\t| |\tName: Platinum \n\t| |\tAtomic weight: 195.09 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 79:
                        Console.WriteLine("\t| | \tSymbol: Au \n\t| |\tName: Gold \n\t| |\tAtomic weight: 196.97 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 80:
                        Console.WriteLine("\t| | \tSymbol: Hg \n\t| |\tName: Mercury \n\t| |\tAtomic weight: 200.59 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 81:
                        Console.WriteLine("\t| | \tSymbol: Tl \n\t| |\tName: Thallium \n\t| |\tAtomic weight: 204.37 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 82:
                        Console.WriteLine("\t| | \tSymbol: Pb \n\t| |\tName: Lead \n\t| |\tAtomic weight: 207.2 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 83:
                        Console.WriteLine("\t| | \tSymbol: Bi \n\t| |\tName: Bismuth \n\t| |\tAtomic weight: 208.98 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 84:
                        Console.WriteLine("\t| | \tSymbol: Po \n\t| |\tName: Polonium \n\t| |\tAtomic weight: 209 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 85:
                        Console.WriteLine("\t| | \tSymbol: At \n\t| |\tName: Astatine \n\t| |\tAtomic weight: 210 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 86:
                        Console.WriteLine("\t| | \tSymbol: Rn \n\t| |\tName: Radon \n\t| |\tAtomic weight: 222 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 87:
                        Console.WriteLine("\t| | \tSymbol: Fr \n\t| |\tName: Francium \n\t| |\tAtomic weight: 223 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 88:
                        Console.WriteLine("\t| | \tSymbol: Ra \n\t| |\tName: Radium \n\t| |\tAtomic weight: 226.02 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 89:
                        Console.WriteLine("\t| | \tSymbol: Ac \n\t| |\tName: Actinium \n\t| |\tAtomic weight: 227.03 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 90:
                        Console.WriteLine("\t| | \tSymbol: Th \n\t| |\tName: Thorium \n\t| |\tAtomic weight: 232.04 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 91:
                        Console.WriteLine("\t| | \tSymbol: Pa \n\t| |\tName: Protactinium \n\t| |\tAtomic weight: 231.03 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 92:
                        Console.WriteLine("\t| | \tSymbol: U \n\t| |\tName: Uranium \n\t| |\tAtomic weight: 238.03 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 93:
                        Console.WriteLine("\t| | \tSymbol: Np \n\t| |\tName: Neptunium \n\t| |\tAtomic weight: 237.05 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 94:
                        Console.WriteLine("\t| | \tSymbol: Pu \n\t| |\tName: Plutonium \n\t| |\tAtomic weight: 242 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 95:
                        Console.WriteLine("\t| | \tSymbol: Am \n\t| |\tName: Americium \n\t| |\tAtomic weight: 243 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 96:
                        Console.WriteLine("\t| | \tSymbol: Cm \n\t| |\tName: Curium \n\t| |\tAtomic weight: 247 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 97:
                        Console.WriteLine("\t| | \tSymbol: Bk \n\t| |\tName: Berkelium \n\t| |\tAtomic weight: 247 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 98:
                        Console.WriteLine("\t| | \tSymbol: Cf \n\t| |\tName: Californium \n\t| |\tAtomic weight: 251 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 99:
                        Console.WriteLine("\t| | \tSymbol: Es \n\t| |\tName: Einsteinium \n\t| |\tAtomic weight: 252 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 100:
                        Console.WriteLine("\t| | \tSymbol: Fm \n\t| |\tName: Fermium \n\t| |\tAtomic weight: 257 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 101:
                        Console.WriteLine("\t| | \tSymbol: Md \n\t| |\tName: Mendelevium \n\t| |\tAtomic weight: 258 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 102:
                        Console.WriteLine("\t| | \tSymbol: No \n\t| |\tName: Nobelium \n\t| |\tAtomic weight: 250 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 103:
                        Console.WriteLine("\t| | \tSymbol: Lr \n\t| |\tName: Lawrencium \n\t| |\tAtomic weight: 260 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 104:
                        Console.WriteLine("\t| | \tSymbol: Rf \n\t| |\tName: Rutherfordium \n\t| |\tAtomic weight: 261 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 105:
                        Console.WriteLine("\t| | \tSymbol: Db \n\t| |\tName: Dubnium \n\t| |\tAtomic weight: 262 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 106:
                        Console.WriteLine("\t| | \tSymbol: Sg \n\t| |\tName: Seaborgium \n\t| |\tAtomic weight: 263 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 107:
                        Console.WriteLine("\t| | \tSymbol: Bh \n\t| |\tName: Bohrium \n\t| |\tAtomic weight: 262 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 108:
                        Console.WriteLine("\t| | \tSymbol: Hs \n\t| |\tName: Hassium \n\t| |\tAtomic weight: 255 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 109:
                        Console.WriteLine("\t| | \tSymbol: Mt \n\t| |\tName: Meitnerium \n\t| |\tAtomic weight: 256 ");;
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 110:
                        Console.WriteLine("\t| | \tSymbol: Ds \n\t| |\tName: Darnstadtium \n\t| |\tAtomic weight: 269 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 111:
                        Console.WriteLine("\t| | \tSymbol: Rg \n\t| |\tName: Roentgenium \n\t| |\tAtomic weight: 272 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 112:
                        Console.WriteLine("\t| | \tSymbol: Cn \n\t| |\tName:Cn Copernicium \n\t| |\tAtomic weight: 285 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 113:
                        Console.WriteLine("\t| | \tSymbol: Nh \n\t| |\tName: Nihonium \n\t| |\tAtomic weight: 286 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 114:
                        Console.WriteLine("\t| | \tSymbol: Fi \n\t| |\tName: Flerovium \n\t| |\tAtomic weight: 289 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 115:
                        Console.WriteLine("\t| | \tSymbol: Mc \n\t| |\tName: Moscovium \n\t| |\tAtomic weight: 289 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 116:
                        Console.WriteLine("\t| |\tSymbol: Lv \n\t| |\tName: Livermorium \n\t| |\tAtomic weight: 293 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 117:
                        Console.WriteLine("\t| | \tSymbol: Ts \n\t| |\tName: Tennessine \n\t| |\tAtomic weight: 294 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    case 118:
                        Console.WriteLine("\t| | \tSymbol: Og \n\t| |\tName: Oganesson \n\t| |\tAtomic weight: 294 ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t| | \t                                                       ");
                        Console.WriteLine("\t******************************************************************\n");
                        break;

                    default:
                        Console.WriteLine("Does not exist");
                        break;

                   

                        /*
                }
            }
            else if (choice == "Group of Elements")
            {

            }
            else if (choice == "Trivia")
            {

            }
            else if (choice == "Natural Occurences")
            {

            }
            else if (choice == "Exit")
            {
                        */
                }
            }

        }
    }
}