using FundamentosCSHARP.Models;
namespace FundamentosCSHARP
{
    class Program
    {

        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();
            //insetarmos nueva cerveza
            /*    {
                   Cerveza cerveza = new Cerveza(15, "Pale Pale");
                   cerveza.Marca= "Minerva";
                   cerveza.Alcohol = 6;
                   cervezaBD.Add(cerveza);
               } */
            //editamos
            /*   {
                  Cerveza cerveza = new Cerveza(4, "Pale Pale");
                  cerveza.Marca= "Minerva";
                  cerveza.Alcohol = 4;
                  cervezaBD.Edit(cerveza, 4);
              } */

            //Eliminar

            {
                cervezaBD.Delit(5);
            }
            
            //obtener todas las cervezas

            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }

        }

        /*  static void Main(string []args){

             var bebidaAlcoholica = new Vino(100);
             MostrarRecomentacion(bebidaAlcoholica);
         }

         static void MostrarRecomentacion(IBebidaAlcoholica bebida){
             bebida.MaxRecomendado();
         } */
        /*     Bebida bebida = new Bebida("Coca cola",1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);

            //formas de hacer listas
            List<Cerveza> cervezas = new List<Cerveza>(){ new Cerveza(10,"CERVESA")};
            cervezas.Add(new Cerveza(500));
            Cerveza erdinger = new Cerveza (500,"Cerveza de trigo");
            cervezas.Add(erdinger);

            foreach( var cerveza in cervezas){
                Console.WriteLine("Cervesa "+ cervezas.Nombre) ;
            }*/

    }
}