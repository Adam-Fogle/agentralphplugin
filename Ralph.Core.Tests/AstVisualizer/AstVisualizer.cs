using System;
using ICSharpCode.NRefactory.Ast;
using QuickGraph;

namespace AgentRalph.Tests.AstVisualizer
{
  public static class AstVisualizerHelper
  {
    public static void Show(INode AST)
    {
      var g = new BidirectionalGraph<INode, IEdge<INode>>();

      Action<INode> add = null;
      add = ast => {
                     g.AddVertex(ast);
                      // BUG: Children isn't populated.  So this doesn't work..
                     foreach (var child in ast.Children) {
                       add(child);
                       g.AddEdge(new Edge<INode>(ast, child));
                     }
      };

      add(AST);

      new VisualizerControl(g).ShowDialog();
    }
  }
}