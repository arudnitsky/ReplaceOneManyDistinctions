using System.Collections.Generic;

namespace ReplaceOneManyDistinctions.Spec
{
   public class CompositeSpec : ISpec
   {
      private List<ISpec> _specs;

      public CompositeSpec( List<ISpec> specs )
      {
         _specs = specs;
      }

      public List<ISpec> GetSpecs()
      {
         return _specs;
      }

      public bool IsSatisfiedBy(  Product product )
      {
         bool satisfiesAllSpecs = true;
         foreach ( var productSpec in GetSpecs() )
         {
            satisfiesAllSpecs &= productSpec.IsSatisfiedBy( product );
         }
         return satisfiesAllSpecs;
      }
   }
}
