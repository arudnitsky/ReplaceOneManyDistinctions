﻿using System.Collections.Generic;

namespace ReplaceOneManyDistinctions.Spec
{
   public class CompositeSpec
   {
      private readonly List<ISpec> _specs = new List<ISpec>();

      public CompositeSpec( List<ISpec> specs )
      {
         _specs = specs;
      }

      public List<ISpec> GetSpecs()
      {
         return _specs;
      } 
   }
}