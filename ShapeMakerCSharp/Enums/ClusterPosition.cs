using System;
namespace ShapeMakerCSharp
{
	public enum ClusterPosition
	{
		/// word sticks out to the left of the cluster
		leading,
		/// word sticks out to the right of the cluster
		trailing,
		/// the entire word is within the cluster block and doesnt stick out
		middle,
		/// sticks out on both sides of the cluster.  Not implemented in this version
		outer
	}
}