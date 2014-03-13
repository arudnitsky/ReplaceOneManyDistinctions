using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceOneManyDistinctions.Spec;

namespace ReplaceOneManyDistinctions.Test
{
   [TestClass]
   public class ProductRepositoryTest
   {
      private static ProductRepository _repository;
      private static Product _fireTruck;
      private static Product _barbieClassic;
      private static Product _frisbee;
      private static Product _baseball;
      private static Product _toyConvertible;

      [ClassInitialize]
      public static void Setup( TestContext context )
      {
         _fireTruck = new Product
         {
            Description = "Fire Truck",
            ProductCode = "f1234",
            Color = ProductColor.Red,
            Price = 8.95,
            Size = ProductSize.Medium
         };

         _barbieClassic = new Product
         {
            Description = "Barbie Classic",
            ProductCode = "b7654",
            Color = ProductColor.Yellow,
            Price = 15.95,
            Size = ProductSize.Small
         };

         _frisbee = new Product
         {
            Description = "Frisbee",
            ProductCode = "f4321",
            Color = ProductColor.Pink,
            Price = 9.99,
            Size = ProductSize.Large
         };

         _baseball = new Product
         {
            Description = "Baseball",
            ProductCode = "b2343",
            Color = ProductColor.White,
            Price = 8.95,
            Size = ProductSize.NotApplicable
         };

         _toyConvertible = new Product
         {
            Description = "Toy Porsche Convertible",
            ProductCode = "p1112",
            Color = ProductColor.Red,
            Price = 230.00,
            Size = ProductSize.NotApplicable
         };

         _repository = new ProductRepository
         {
            _fireTruck,
            _barbieClassic,
            _frisbee,
            _baseball,
            _toyConvertible
         };
      }

      [TestMethod]
      public void SelectBy_FindByColor_RetrievesCorrectItems()
      {
         var foundProducts = _repository.SelectBy( new ColorSpec( ProductColor.Red ) ).ToList();

         Assert.AreEqual( 2, foundProducts.Count );
         Assert.IsTrue( foundProducts.Contains( _fireTruck ) );  
         Assert.IsTrue( foundProducts.Contains( _toyConvertible ) );  
      }

      [TestMethod]
      public void SelectBy_FindByColorAndSizeAndPrice_RetrievesCorrectItems()
      {
         var specs = new List<ISpec>
         {
            new ColorSpec( ProductColor.Red ),
            new SizeSpec( ProductSize.Small ),
            new BelowPriceSpec( 10.00 )
         };

         var foundProducts = _repository.SelectBy( new CompositeSpec( specs ) );

         Assert.AreEqual( 0, foundProducts.Count() );
      }
   }
}
