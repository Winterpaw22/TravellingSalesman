using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    public class Product
    {
        public enum ProductType
        {
            None,
            Furry,
            Spotted,
            Dancing
        }


        private int _numberOfUnits;
        private bool _onBackorder;
        private ProductType _type;



        public ProductType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool OnBackorder
        {
            get { return _onBackorder; }
            set { _onBackorder = value; }
        }
        public int NumberOfUnits
        {
            get { return _numberOfUnits; }
        }

        #region Methods

        /// <summary>
        /// Increments numberOfUnits property
        /// </summary>
        /// <param name="unitsToAdd"></param>
        public void AddProducts(int unitsToAdd)
        {
            
            _numberOfUnits += unitsToAdd;
        }

        /// <summary>
        /// Decrements NumberOfUnits property and sets OnBackorder status
        /// </summary>
        /// <param name="unitsToSubtract"></param>
        public void SubtractProducts(int unitsToSubtract)
        {

            if (_numberOfUnits < unitsToSubtract)
            {
                _onBackorder = true;
            }
            _numberOfUnits -= unitsToSubtract;
        }
        #endregion
        public void ResetProductAmount()
        {
            _numberOfUnits = 0;
        }
        public Product()
        {
           
        }

        public Product(ProductType type, int numberOfUnits)
        {

        }



        

    }
}
