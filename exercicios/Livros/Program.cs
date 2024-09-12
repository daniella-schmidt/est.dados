using Livros;
    {
        List<Books> book = new List<Books>();

        Books l1 = new Books()
        {
            Name = "mocotó",
            numberpage = 30,
            Author = "lucinho das goiabas",
            Editor = Editor.Darkside
        };
        book.Add(l1);

        Books l2 = new Books()
        {
            Name = "como trocar um  pneu",
            numberpage = 850,
            Author = "loco das motocas",
            Editor = Editor.Record
        };
        book.Add(l2);

        Books l3 = new Books()
        {
            Name = "conexao: como fechar uma porta",
            numberpage = 2,
            Author = "grupo do 8 ano",
            Editor = Editor.HarperCollins
        };
        book.Add(l3);

        Books l4 = new Books()
        {
            Name = "a figuera que me possue",
            numberpage = 200,
            Author = "xique-xique",
            Editor = Editor.Darkside
        };
        book.Add(l4);

        Books MPages = null;
        int maxPages = 0;

            foreach (var item in book)
            {
                Console.WriteLine($"Book: {item.Name} by {item.Author} ({item.Editor})");

                if (item.numberpage > maxPages)
                {
                    maxPages = item.numberpage;
                    MPages = item;
                }
            }

            Console.WriteLine("\nBook with most pages:");
            Console.WriteLine($"Book: {MPages.Name} by {MPages.Author} ({MPages.Editor}) with {MPages.numberpage} pages");
    }
