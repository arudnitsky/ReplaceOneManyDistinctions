using System.Collections.Generic;

namespace ReplaceOneManyDistinctions.Spec
{
   public class CompositeSpec : ISpec
   {
      private readonly List<ISpec> _specs = new List<ISpec>();

      public CompositeSpec()
      {
      }

      public List<ISpec> GetSpecs()
      {
         return _specs;
      }

      public void Add( ISpec spec )
      {
         _specs.Add( spec );
      }

      public bool IsSatisfiedBy( Product product )
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
