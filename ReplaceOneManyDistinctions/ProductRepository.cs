﻿using System.Collections;
using System.Collections.Generic;
using ReplaceOneManyDistinctions.Spec;

namespace ReplaceOneManyDistinctions
{
   public class ProductRepository : IEnumerable<Product>
   {
      private readonly List<Product> _products = new List<Product>();
 
      public void Add( Product product )
      {
         _products.Add( product );
      }

      public List<Product> SelectBy( ISpec spec )
      {
         var foundProducts = new List<Product>();

         foreach ( var product in _products )
         {
            if ( spec.IsSatisfiedBy( product ) )
            {
               foundProducts.Add( product );
            } 
         }

         return foundProducts;
      }

      #region IEnumerable implementation
      IEnumerator<Product> IEnumerable<Product>.GetEnumerator()
      {
         return _products.GetEnumerator();
      }

      public IEnumerator GetEnumerator()
      {
         return _products.GetEnumerator();
      }
      #endregion
   }
}
