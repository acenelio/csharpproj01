using System.Globalization;

namespace curso {
    class Produto {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco) {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString() {
            return codigo
                + ", "
                + descricao
                + ", Preço: "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
