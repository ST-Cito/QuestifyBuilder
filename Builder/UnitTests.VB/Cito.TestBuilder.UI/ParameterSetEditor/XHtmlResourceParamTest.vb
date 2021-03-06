﻿
Option Infer On
Imports FakeItEasy
Imports System.Text
Imports Cito.Tester.ContentModel
Imports Cito.Tester.Common
Imports Questify.Builder.Model.ContentModel.EntityClasses
Imports Questify.Builder.UI
Imports Questify.Builder.UnitTests.Framework.FakeAppTemplate

<TestClass()>
Public Class XHtmlResourceParamTest

    <TestMethod(), TestCategory("UILogic")>
    Public Sub GetResourceOnAddEventHandler()
        FakeDal.Init()
        Try
            Dim resourceMan = FakeDal.GetFakeResourceManager()
            Dim paramEditor As New ParameterSetsEditor()
            Dim itemResource As New ItemResourceEntity()
            Dim resourceParam = New XhtmlResourceParameter()
            resourceParam.Name = "Test"
            resourceParam.Value = "Tale of two cities"

            Dim ctrl As New XhtmlResourceParameterEditorControl(paramEditor, resourceParam, itemResource, resourceMan)

            Dim handler = A.Fake(Of EventHandler(Of ResourceNeededEventArgs))()

            A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).
                Invokes(Sub(i)
                            Dim e = i.GetArgument(Of ResourceNeededEventArgs)(1)
                            e.BinaryResource = New BinaryResource(e.ResourceName, Nothing, Encoding.UTF8.GetBytes(" It was the best of times, it was the worst of times"), Nothing)
                        End Sub)

            AddHandler ctrl.ResourceNeeded, handler

            A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).MustHaveHappened(Repeated.Exactly.Once)
        Finally
            FakeDal.Deinit()
        End Try
    End Sub

    <TestMethod(), TestCategory("UILogic")>
    Public Sub AreReferentiesInitialized()
        Dim txt = <html><body><p> It was the best of times, it was the worst of times 
                <span id="ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"
                    contenteditable="false"
                    cito:type="reference"
                    cito:reftype="Element"
                    cito:description="Element 1"
                    cito:value="1"
                    xmlns:cito="http://www.cito.nl/citotester"
                    xmlns="http://www.w3.org/1999/xhtml">__1__</span></p>
                      </body></html>.ToString()
        FakeDal.Init()
        Try
            Dim resourceMan = FakeDal.GetFakeResourceManager()
            Dim paramEditor As New ParameterSetsEditor()
            Dim itemResource As New ItemResourceEntity()
            Dim resourceParam = New XhtmlResourceParameter() With {.Name = "Test", .Value = "Tale of two cities"}

            Dim ctrl As New XhtmlResourceParameterEditorControl(paramEditor, resourceParam, itemResource, resourceMan)

            Dim handler = A.Fake(Of EventHandler(Of ResourceNeededEventArgs))()
            A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).
                Invokes(Sub(i)
                            Dim e = i.GetArgument(Of ResourceNeededEventArgs)(1)
                            e.BinaryResource = New BinaryResource(e.ResourceName, Nothing, Encoding.UTF8.GetBytes(txt), Nothing)
                        End Sub)

            AddHandler ctrl.ResourceNeeded, handler

            Dim lst As XhtmlReferenceList = TryCast(ctrl.XhtmlReferenceBindingSource.DataSource, XhtmlReferenceList)
            Assert.IsNotNull(lst)
            Assert.AreEqual(2, lst.Count)
        Finally
            FakeDal.Deinit()
        End Try
    End Sub

    <TestMethod(), TestCategory("UILogic"), WorkItem(8918)>
    Public Sub ActiveReferenceIsSetWhenParameterHasValueForIt()
        Dim txt = <html><body><p> It was the best of times, it was the worst of times 
                <span id="ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"
                    contenteditable="false"
                    cito:type="reference"
                    cito:reftype="Element"
                    cito:description="Element 1"
                    cito:value="1"
                    xmlns:cito="http://www.cito.nl/citotester"
                    xmlns="http://www.w3.org/1999/xhtml">__1__</span></p>
                      </body></html>.ToString()
        FakeDal.Init()
        Dim resourceMan = FakeDal.GetFakeResourceManager()
        Dim paramEditor As New ParameterSetsEditor()
        Dim itemResource As New ItemResourceEntity()
        Dim resourceParam = New XhtmlResourceParameter() With {.Name = "Test", .Value = "Tale of two cities"}
        resourceParam.Nodes(0).InnerText = "ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"

        Dim ctrl As New XhtmlResourceParameterEditorControl(paramEditor, resourceParam, itemResource, resourceMan)

        Dim handler As EventHandler(Of ResourceNeededEventArgs) = A.Fake(Of EventHandler(Of ResourceNeededEventArgs))()
        A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).
            Invokes(Sub(i)
                        Dim e = i.GetArgument(Of ResourceNeededEventArgs)(1)
                        e.BinaryResource = New BinaryResource(e.ResourceName, Nothing, Encoding.UTF8.GetBytes(txt), Nothing)
                    End Sub)

        AddHandler ctrl.ResourceNeeded, handler

        Assert.AreEqual("ref8d8d8f6c-9391-45bc-865b-366b8f1c9485", ctrl.ReferenceComboBox.SelectedValue.ToString(), "Should have been set to correct ref id.")
        FakeDal.Deinit()
    End Sub

    <TestMethod(), TestCategory("UILogic"), WorkItem(8918)>
    Public Sub ActiveReferenceIsNotSetWhen_WhenREsourceNeededIsNotSet()
        Dim txt = <html><body><p> It was the best of times, it was the worst of times 
                <span id="ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"
                    contenteditable="false"
                    cito:type="reference"
                    cito:reftype="Element"
                    cito:description="Element 1"
                    cito:value="1"
                    xmlns:cito="http://www.cito.nl/citotester"
                    xmlns="http://www.w3.org/1999/xhtml">__1__</span></p>
                      </body></html>.ToString()
        FakeDal.Init()
        Dim resourceMan = FakeDal.GetFakeResourceManager()
        Dim paramEditor As New ParameterSetsEditor()
        Dim itemResource As New ItemResourceEntity()
        Dim resourceParam = New XhtmlResourceParameter() With {.Name = "Test", .Value = "Tale of two cities"}
        resourceParam.Nodes(0).InnerText = "ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"

        Dim ctrl As New XhtmlResourceParameterEditorControl(paramEditor, resourceParam, itemResource, resourceMan)

        Dim handler As EventHandler(Of ResourceNeededEventArgs) = A.Fake(Of EventHandler(Of ResourceNeededEventArgs))()
        A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).
            Invokes(Sub(i)
                        Dim e = i.GetArgument(Of ResourceNeededEventArgs)(1)
                        e.BinaryResource = New BinaryResource(e.ResourceName, Nothing, Encoding.UTF8.GetBytes(txt), Nothing)
                    End Sub)


        Assert.AreEqual(Nothing, ctrl.ReferenceComboBox.SelectedValue)
        FakeDal.Deinit()
    End Sub

    <TestMethod(), TestCategory("UILogic"), WorkItem(9083)>
    Public Sub SelectNewSourceText_ComboShouldReInit()
        Dim txt = <html><body><p> It was the best of times, it was the worst of times 
                <span id="ref8d8d8f6c-9391-45bc-865b-366b8f1c9485"
                    contenteditable="false"
                    cito:type="reference"
                    cito:reftype="Element"
                    cito:description="Element 1"
                    cito:value="1"
                    xmlns:cito="http://www.cito.nl/citotester"
                    xmlns="http://www.w3.org/1999/xhtml">__1__</span></p>
                      </body></html>.ToString()
        FakeDal.Init()
        Try
            Dim resourceMan = FakeDal.GetFakeResourceManager()
            Dim paramEditor As New ParameterSetsEditor()
            Dim itemResource As New ItemResourceEntity()
            Dim resourceParam = New XhtmlResourceParameter()

            Dim ctrl As New XhtmlResourceParameterEditorControl(paramEditor, resourceParam, itemResource, resourceMan)

            Dim handler As EventHandler(Of ResourceNeededEventArgs) = A.Fake(Of EventHandler(Of ResourceNeededEventArgs))()
            A.CallTo(Sub() handler.Invoke(A(Of Object).Ignored, A(Of ResourceNeededEventArgs).Ignored)).
                Invokes(Sub(i)
                            Dim e = i.GetArgument(Of ResourceNeededEventArgs)(1)
                            e.BinaryResource = New BinaryResource(e.ResourceName, Nothing, Encoding.UTF8.GetBytes(txt), Nothing)
                        End Sub)

            Dim eventRaised As Boolean = False
            AddHandler ctrl.ParameterBindingSource.CurrentItemChanged, Sub()
                                                                           eventRaised = True
                                                                       End Sub
            AddHandler ctrl.ResourceNeeded, handler

            ctrl.ResourceParameter.Value = "Tale of two cities"

            Assert.IsTrue(eventRaised, "Check if changed event has been raised")
            Dim references As XhtmlReferenceList = DirectCast(ctrl.XhtmlReferenceBindingSource.DataSource, XhtmlReferenceList)
            Assert.AreEqual(2, references.Count)
        Finally
            FakeDal.Deinit()
        End Try
    End Sub

End Class
