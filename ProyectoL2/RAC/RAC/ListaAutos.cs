using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAC
{
   public class ListaAutos
    {
       public BindingList<Auto> AutoLista { get; set; }


       public ListaAutos()
       {
           AutoLista = new BindingList<Auto>();
           CrearLista();
       }

       public double ObtenerPrecio(int id)
       {
           double precio = 0;

           foreach (var auto in AutoLista)
           {
               if (auto.Id == id)
               {
                   precio = auto.Precio;
               }
           }

           return precio;

       }

        private void CrearLista()
        {
            var auto1 = new Auto();
            auto1.Id = 1;
            auto1.Marca = "Toyota";
            auto1.Modelo = "Corolla";
            auto1.Año = "2000";
            auto1.Precio = 300;
            auto1.Disponible = true;
     

            var auto2 = new Auto();
            auto2.Id = 2;
            auto2.Marca = "Ford";
            auto2.Modelo = "Escape";
            auto2.Año = "2010";
            auto2.Precio = 500;
            auto2.Disponible=true;


            var auto3 = new Auto();
            auto3.Id = 3;
            auto3.Marca = "Honda";
            auto3.Modelo = "Civic";
            auto3.Año = "2015";
            auto3.Precio = 800;
            auto3.Disponible = true;

            AutoLista.Add(auto1);
            AutoLista.Add(auto2);
            AutoLista.Add(auto3);
           }
   
        

       }
}
