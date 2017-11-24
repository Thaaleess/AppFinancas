namespace Financas.Domain
{
    public class Financa
    {
        public Financa(){
            
        }

        public Financa(int id, string data, string numero_doc, Despesa despesa, string local_compra, float valor){
            this.id = id;
            this.data = data;
            this.numero_doc = numero_doc;
            this.Despesa = despesa;
            this.local_compra = local_compra;
            this.valor = valor;
        }

        public int id { get; set; }
        public string data { get; set; }
        public string numero_doc { get; set; }
        public Despesa Despesa { get; set; }
        public string local_compra { get; set; }
        public float valor { get; set; }


    }
}