using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada = 1;//uint não aceita negativo

        //construtor
        public Moto(string Marca, string Modelo, uint Cilindrada)
        {
            //this.Marca = Marca;
            //this.Modelo = Modelo;
            //this.Cilindrada = Cilindrada;

            //todos passam pelo set, agora
            setMarca(Marca);
            setModelo(Modelo);
            setCilindrada(Cilindrada);

        }

        //contrutor padrão
        public Moto(){

        }

        public string getMarca()
        {
            return Marca;
        }

        public void setMarca(string marca)
        {
            Marca = marca;
        }

        public string getModelo()
        {
            return Modelo;
        }

        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint getCilindrada()
        {
            return Cilindrada;
        }

        public void setCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;
            //if (cilindrada>0) {
            //    Cilindrada = cilindrada;
            //}

            //se recebe valor negativo transforma em positivo
            //Cilindrada = Math.Abs(cilindrada);
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja", 636);

            Console.WriteLine(moto1.getMarca());
            Console.WriteLine(moto1.getModelo());
            Console.WriteLine(moto1.getCilindrada());

            var moto2 = new Moto();
                moto2.setMarca("Yamaha");
                moto2.setModelo("CBR");
                moto2.setCilindrada(600);

            Console.WriteLine(moto2.getMarca() 
                + "\n" + moto2.getModelo() 
                + "\n" + moto2.getCilindrada());

        }
    }
}
