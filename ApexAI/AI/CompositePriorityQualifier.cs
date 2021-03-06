using Apex.Serialization;
using System;
using System.Collections.Generic;

namespace Apex.AI
{
	[AICategory("Composite Qualifiers")]
	[FriendlyName("Sum while above threshold", "Scores by summing child scores, until a child scores below the threshold")]
	public class CompositePriorityQualifier : CompositeQualifier
	{
		[ApexSerialization(defaultValue=0f)]
		public float threshold;

		public CompositePriorityQualifier()
		{
		}

		public sealed override float Score(IAIContext context, IList<IContextualScorer> scorers)
		{
			float single = 0f;
			int count = scorers.Count;
			for (int i = 0; i < count; i++)
			{
				IContextualScorer item = scorers[i];
				if (!item.isDisabled)
				{
					float single1 = item.Score(context);
					if (single1 <= this.threshold)
					{
						return single;
					}
					single += single1;
				}
			}
			return single;
		}
	}
}