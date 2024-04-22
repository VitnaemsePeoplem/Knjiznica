using System.Collections.Generic;
using System.Windows.Forms;

public class Helper
{
    public static void PrikaziListuUListboxu<NekiTip>(List <NekiTip> lista, ListBox listbox)
    {
        listbox.Items.Clear();
        lista.Sort();
        foreach(NekiTip element in lista)
        {
            listbox.Items.Add(element);
        }
    }
}