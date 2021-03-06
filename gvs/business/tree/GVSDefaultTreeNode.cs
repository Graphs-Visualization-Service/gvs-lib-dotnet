using System;

namespace gvs_lib_csharp.gvs.business.tree
{
	/// <summary>
	/// Represents a DefaultTreeNode.
	/// </summary>
	public interface GVSDefaultTreeNode:GVSTreeNode {

		/// <summary>
		/// Returns all childnodes
		/// </summary>
		/// <returns>childnodes</returns>
		GVSDefaultTreeNode[] GetGvsChildNodes();
	}
}
