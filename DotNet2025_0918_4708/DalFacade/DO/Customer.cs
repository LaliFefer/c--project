namespace DO;

    public record Customer(int Id, String name, String address, string PhonNumber)
    {
        public Customer() : this(122, "Moshe", "RamatEshcol", "0583228882")
        {

        }
    }

