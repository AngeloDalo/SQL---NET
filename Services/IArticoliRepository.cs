using System.Collections.Generic;
using System.Threading.Tasks;
using ArticoliWebService.Models;

namespace ArticoliWebService.Services
{
    public interface IArticoliRepository
    {
        ICollection<Articoli> SelArticoliByDescrizione(string Descrizione); //selezionare i dati in base alla descrizione, restituisce collezzione
        Articoli SelArticoloByCodice(string Code); //selezionare articolo in base al codice interno (classe primaria), restituisce classe
        Articoli SelArticoloByEan(string Ean); //restituire articolo in base al codice a bassa univoco
        bool InsArticoli(Articoli articolo); //inserire articolo
        bool UpdArticoli(Articoli articolo); //modificare articolo
        bool DelArticoli(Articoli articolo); //eliminare articolo
        bool Salva(); //Salvare articolo
        Task<bool> ArticoloExists(string Code); //vedere se articolo e' gia' presente
    }
}