namespace Search_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Avoid null warning
            allProducts = new Product[0];
            cacheResults = new Product[0];
            lastResult = string.Empty;
            InitializeComponent();
        }

        Product[] allProducts;
        Product[] cacheResults;
        string lastResult;

        //
        // Form Events
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] product;
            string[] products = File.ReadAllLines("productList.txt");
            allProducts = new Product[products.Length];
            for (int i = 0; i < products.Length; i++)
            {
                product = products[i].Split(',');
                allProducts[i] = new Product(
                    product[0],
                    Convert.ToDouble(product[1]),
                    Convert.ToInt32(product[2])
                    );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get input from user
            string sQuery = txtSearch.Text;

            if (sQuery == "")
            {
                dgvResults.Rows.Clear();
                return;
            }

            string[] aQuery = sQuery.Split(' ');

            // Empty query
            if (sQuery.Length == 0)
            {
                dgvResults.Rows.Clear();
                return;
            }

            // Choose the correct array
            if (sQuery.Substring(0, sQuery.Length - 1) == lastResult && lastResult != "")
            {
                if (cacheResults.Length > 0)
                {
                    searchCache(aQuery);
                    return;
                }
            }
            else
            {
                searchFull(aQuery);
            }

            lastResult = sQuery;
        }

        //
        // Search Methods
        //
        private void searchFull(string[] query)
        {
            // Init array for holding results
            int maxResults = 50;
            Product[] results = new Product[maxResults];
            int nResults;


            // Check for query
            nResults = 0;
            bool valid;
            for (int i = 0; i < allProducts.Length; i++)
            {
                valid = true;
                for (int j = 0; j < query.Length; j++)
                {
                    // .ToUpper() is used so the user doesn't have to worry about getting capitals perfectly correct
                    if (!allProducts[i].Name.ToUpper().Contains(query[j].ToUpper()))
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid) continue;

                // The product contains the query
                results[nResults] = allProducts[i];
                nResults++;
                if (nResults == maxResults)
                {
                    break;
                }
            }

            // In case there were less results than the max, shrinks the array to the correct size
            results = ridNulls(results);

            // Display results
            dgvResults.Rows.Clear();
            string[] row;
            for (int i = 0; i < results.Length; i++)
            {
                row = results[i].getData();
                dgvResults.Rows.Add(row);
            }

            // Cache results
            cacheResults = results;
        }

        private void searchCache(string[] query)
        {
            // Init array for holding results
            int maxResults = 50;
            Product[] results = new Product[maxResults];
            int nResults;


            // Check for query
            nResults = 0;
            bool valid;
            for (int i = 0; i < cacheResults.Length; i++)
            {
                valid = true;
                for (int j = 0; j < query.Length; j++)
                {
                    // .ToUpper() is used so the user doesn't have to worry about getting capitals perfectly correct
                    if (!cacheResults[i].Name.ToUpper().Contains(query[j].ToUpper()))
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid) continue;

                // The product contains the query
                results[nResults] = cacheResults[i];
                nResults++;
                if (nResults == maxResults)
                {
                    break;
                }
            }

            for (int i = cacheResults[cacheResults.Length-1].Code; i < allProducts.Length; i++)
            {
                if (nResults == maxResults)
                {
                    break;
                }

                valid = true;
                for (int j = 0; j < query.Length; j++)
                {
                    // .ToUpper() is used so the user doesn't have to worry about getting capitals perfectly correct
                    if (!allProducts[i].Name.ToUpper().Contains(query[j].ToUpper()))
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid) continue;

                // The product contains the query
                results[nResults] = allProducts[i];
                nResults++;
            }

            // In case there were less results than the max, shrinks the array to the correct size
            results = ridNulls(results);

            // Display results
            dgvResults.Rows.Clear();
            string[] row;
            for (int i = 0; i < results.Length; i++)
            {
                row = results[i].getData();
                dgvResults.Rows.Add(row);
            }

            // Cache results
            cacheResults = results;
        }

        //
        // Methods
        //
        private Product[] ridNulls(Product[] array)
        {
            // This method is for an array that has trailing null data.
            // If the array has a null within the data then any data after that null will be removed

            // Count actual data
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null) // End of data
                {
                    break;
                }
                count++;
            }

            // Create actual array
            Product[] new_array = new Product[count];
            for (int i = 0; i < count; i++)
            {
                new_array[i] = array[i];
            }

            return new_array;
        }
    }
}
