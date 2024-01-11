using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vero_o_Falso : Domanda
{
    //attributi
    private string _dom;
    private int _risposta;

    public string Dom
    {
        get { return _dom; }
        set { _dom = value; }
    }
    public int Risposta
    {
        get { return _risposta; }
        set { _risposta = value; }
    }

    //costruttori
    public Vero_o_Falso()
    {
        Dom = "";
        Risposta = 0;
    }
    public Vero_o_Falso(string dom, int risposta)
    {
        Dom = dom;
        Risposta = risposta;
    }
    public Vero_o_Falso(Vero_o_Falso n)
    {
        Dom = n.Dom;
        Risposta = n.Risposta;
    }

    //Metodi interfaccia
    public void add(Domanda d)
    {

    }
    public void remove(int index)
    {

    }
    public Domanda getChild()
    {

    }
}
