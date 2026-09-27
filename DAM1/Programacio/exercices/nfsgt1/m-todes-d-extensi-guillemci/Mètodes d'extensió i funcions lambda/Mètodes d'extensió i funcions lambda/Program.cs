namespace Mètodes_d_extensió_i_funcions_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            bool final = false;
            while (!final)
            {
                Console.Clear();
                MostraMenus.MenuTria();
                valor = Console.ReadLine();

                switch (valor)
                {
                    case "1":
                        Console.Clear();
                        MostraMenus.ExtensionsDeCaracters();
                        MostraMenus.ControlMenu();
                        break;
                    case "2":
                        Console.Clear();
                        MostraMenus.ExtensionsDeInts();
                        MostraMenus.ControlMenu();
                        break;
                    case "3":
                        Console.Clear();
                        MostraMenus.ExtensionsDeStrings();
                        MostraMenus.ControlMenu();
                        break;
                    case "4":
                        Console.Clear();
                        MostraMenus.ExtensionsDeDates();
                        MostraMenus.ControlMenu();
                        break;
                    case "5":
                        Console.Clear();
                        MostraMenus.ExtensionsDeIEnumerable();
                        MostraMenus.ControlMenu();
                        break;
                    case "6":
                        Console.Clear();
                        MostraMenus.ExtensionsGeneriques();
                        MostraMenus.ControlMenu();
                        break;
                    case "7":
                        final = true;
                        break;
                }
            }
        }
    }
}
