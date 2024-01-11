using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Domanda
{
    void add(Domanda domanda);

    void remove(int index);

    Domanda getChild(int index);

    double punteggio();
}
