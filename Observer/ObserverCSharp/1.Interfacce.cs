using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>Interfaccia ascolto delle notifiche di variazione di stato di un oggetto (soggetto)</summary>
    interface IObserver
    {
        /// <summary>Notifica la variazione di stato del soggetto</summary>
        /// <param name="subject">soggetto che ha subito una variazione di stato</param>
        void Update(ISubject subject);
    }

    /// <summary>Interfaccia di gestione e segnalazione di notifiche di variazione di stato di un oggetto</summary>
    interface ISubject
    {
        /// <summary>Registra l'osservatore interessato alle variazioni di stato dell'oggetto implementante l'interfaccia <see cref="ISubject"/></summary>
        /// <param name="observer">osservatore</param>
        void Attach(IObserver observer);
        /// <summary>Deregistra l'osservatore precedentemente interessato alle variazioni di stato dell'oggetto implementante l'interfaccia <see cref="ISubject"/></summary>
        /// <param name="observer">osservatore</param>
        void Detach(IObserver observer);
        /// <summary>Notifica le variazioni dell'oggetto a tutti gli osservatori</summary>
        void Notify();
    }
}
