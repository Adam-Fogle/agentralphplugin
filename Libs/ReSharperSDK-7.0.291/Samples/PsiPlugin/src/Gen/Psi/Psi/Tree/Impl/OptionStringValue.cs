//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.PsiPlugin.Parsing;
namespace JetBrains.ReSharper.PsiPlugin.Tree.Impl {
  internal partial class OptionStringValue : PsiCompositeElement, JetBrains.ReSharper.PsiPlugin.Tree.IOptionStringValue {
    internal OptionStringValue() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.PsiPlugin.Tree.Impl.ElementType.OPTION_STRING_VALUE; }
    }
    public override void Accept(JetBrains.ReSharper.PsiPlugin.Tree.TreeNodeVisitor visitor) {
      visitor.VisitOptionStringValue(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.PsiPlugin.Tree.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitOptionStringValue(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.PsiPlugin.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitOptionStringValue(this, context);
    }
    public override string ToString() {
      return "IOptionStringValue";
    }
  }
}