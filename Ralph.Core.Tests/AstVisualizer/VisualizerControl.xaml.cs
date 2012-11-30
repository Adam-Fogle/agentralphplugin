using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICSharpCode.NRefactory.Ast;
using QuickGraph;

namespace AgentRalph.Tests.AstVisualizer
{
  /// <summary>
  /// Interaction logic for VisualizerControl.xaml
  /// </summary>
  public partial class VisualizerControl : Window
  {
    private IBidirectionalGraph<INode, IEdge<INode>> _graphToVisualize;

    public IBidirectionalGraph<INode, IEdge<INode>> GraphToVisualize
    {
      get { return _graphToVisualize; }
    }

    public VisualizerControl(IBidirectionalGraph<INode, IEdge<INode>> graphToVisualize)
    {
      _graphToVisualize = graphToVisualize;
      InitializeComponent();
    }
  }
}
