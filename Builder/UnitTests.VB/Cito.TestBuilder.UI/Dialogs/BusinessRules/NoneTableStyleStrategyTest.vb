﻿
Imports FakeItEasy
Imports Questify.Builder.Logic
Imports Questify.Builder.Logic.PluginExtensibility.Html.Handlers.Logic
Imports Questify.Builder.UI.Dialogs.BusinessLogic

<TestClass()>
Public Class NoneTableStyleStrategyTest
    Inherits baseTableStyleTest

    <TestMethod(), TestCategory("UILogic"), TestCategory("Table")>
    Public Sub StyleIsApplied()
        Dim presenter As New BorderAndShadingPresenter(A.Fake(Of IBordersAndShadingView), TableStyleDto.ColAndRow())
        presenter.Style.Inner(LineStyle.Double, 1)
        Dim styleHanler As New NoneTableStyleStrategy(presenter)
        presenter.CurrentLineWidth = 10
        presenter.CurrentLineStyle = LineStyle.Dotted

        styleHanler.CalculateNewStyle()

        Assert.IsTrue(BoxEquals(presenter.Style, LineStyle.Hidden, 0))
        Assert.IsTrue(InnerEquals(presenter.Style, LineStyle.Hidden, 0))
    End Sub

    <TestMethod(), TestCategory("UILogic"), TestCategory("Table")>
    Public Sub TogglesAreSetAfterInit()
        Dim presenter As New BorderAndShadingPresenter(A.Fake(Of IBordersAndShadingView), TableStyleDto.ColAndRow())
        Dim styleHanler As New NoneTableStyleStrategy(presenter)

        styleHanler.InitiateState()

        Assert.IsTrue(styleHanler.GetBoxStatus(False))
        Assert.IsTrue(styleHanler.GetInnerStatus(False))
    End Sub

    <TestMethod(), TestCategory("UILogic"), TestCategory("Table")>
    Public Sub StyleHandlerCanHandleStateAfterInit()
        Dim presenter As New BorderAndShadingPresenter(A.Fake(Of IBordersAndShadingView), TableStyleDto.ColAndRow())
        Dim styleHanler As New NoneTableStyleStrategy(presenter)

        styleHanler.InitiateState()

        Assert.IsTrue(styleHanler.CanHandleState())
    End Sub

    <TestMethod(), TestCategory("UILogic"), TestCategory("Table")>
    Public Sub StyleHandlerCannotHandleIfNotAllChecksAreOn()
        Dim presenter As New BorderAndShadingPresenter(A.Fake(Of IBordersAndShadingView), TableStyleDto.ColAndRow())
        Dim styleHanler As New NoneTableStyleStrategy(presenter)

        styleHanler.InitiateState()
        presenter.TopChecked = True

        Assert.IsFalse(styleHanler.CanHandleState())
    End Sub

End Class
