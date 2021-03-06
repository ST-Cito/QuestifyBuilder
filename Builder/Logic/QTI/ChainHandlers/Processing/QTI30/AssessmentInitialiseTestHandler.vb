﻿Imports System.Collections.Concurrent
Imports Cito.Tester.Common
Imports Cito.Tester.ContentModel
Imports Questify.Builder.Logic.Chain
Imports Questify.Builder.Logic.QTI.Helpers
Imports Questify.Builder.Logic.QTI.Helpers.QTI30
Imports Questify.Builder.Logic.QTI.Helpers.QTI30.QtiModelHelpers
Imports Questify.Builder.Logic.QTI.Model.QTI30
Imports Questify.Builder.Logic.QTI.PackageCreators.QTI_Base
Imports Questify.Builder.Logic.QTI.PackageCreators.QTI30
Imports Questify.Builder.Logic.QTI.Requests.QTI30
Imports Questify.Builder.Logic.QTI.Xsd.QTI30
Imports Questify.Builder.Logic.ResourceManager
Imports ResourceType = Questify.Builder.Logic.QTI.Xsd.QTI30.ResourceType

Namespace QTI.ChainHandlers.Processing.QTI30

    Public Class AssessmentInitialiseTestHandler
        Inherits ChainHandlerBase(Of PublicationRequest)

        Private ReadOnly _assessmenttest As AssessmentTest2
        Private ReadOnly _test As GeneralAssessmentTest
        Protected ReadOnly _packageCreator As PackageCreator
        Protected _resourceTypes As ConcurrentDictionary(Of PackageCreator.QTIManifestResourceType, ResourceTypeType)

        Public Sub New(ByVal asssessmentTest As AssessmentTest2, test As GeneralAssessmentTest, packageCreator As PackageCreator)
            _assessmenttest = asssessmentTest
            _test = test
            _packageCreator = packageCreator
        End Sub

        Private Function GetTestId(identifier As String) As String
            Return identifier.Replace(" ", "_").Replace(".", "_")
        End Function

        Public Overrides Function ProcessRequest(ByVal requestData As PublicationRequest) As ChainHandlerResult
            _resourceTypes = requestData.ResourceTypeDictionary
            Return ExecuteRequest(requestData)
        End Function

        Private Function ExecuteRequest(requestData As PublicationRequest) As ChainHandlerResult
            If requestData.Tests.ContainsKey(GetTestId(_assessmenttest.Identifier)) Then
                Return ChainHandlerResult.RequestHandled
            End If

            Dim dataBaseResourceManager = TryCast(_packageCreator.ResourceMan, DataBaseResourceManager)
            If (dataBaseResourceManager IsNot Nothing) Then
                dataBaseResourceManager.IncludeMetaData = Builder.Logic.ResourceManager.MetaDataType.Publishable
            End If
            Dim testDocumentSet As TestDocumentSet = GetTestDocumentSet(_assessmenttest)
            Dim testHelper = GetTestHelper(_test)

            AddTest(testDocumentSet, testHelper)
            requestData.Tests.Add(GetTestId(_test.Identifier), testDocumentSet)

            Dim resourceType = GetNewResourceType()
            resourceType.identifier = ChainHandlerHelper.GetIdentifierFromResourceId(testDocumentSet.Test.Identifier, PackageCreatorConstants.TypeOfResource.test)
            resourceType.type = _resourceTypes(PackageCreator.QTIManifestResourceType.imsqti_test)

            Dim testMetaDataCollection As MetaDataCollection = _packageCreator.ResourceMan.GetResourceMetaData(testDocumentSet.Test.Identifier)
            testHelper.AddMetadata(resourceType, testMetaDataCollection)
            PackageCreator.AddResourceToManifest(requestData.Resources, resourceType)

            Dim resourceHelper = New ResourceHelper(requestData.FileTypeDictionary, requestData.ResourceTypeDictionary, _packageCreator)
            testHelper.AddAttachmentResources(False, resourceHelper, requestData.Resources, requestData.ResourceMimeTypeDictionary)
            testHelper.AddThemeResources(False, resourceHelper, requestData.Resources, requestData.ResourceMimeTypeDictionary)

            Return ChainHandlerResult.RequestHandled
        End Function

        Protected Overridable Function GetTestDocumentSet(test As AssessmentTest2) As TestDocumentSet
            Return New TestDocumentSet(test)
        End Function

        Protected Overridable Sub AddTest(testDocumentSet As TestDocumentSet, testHelper As TestHelper)
            testDocumentSet.AssessmentTestType = testHelper.CreateAssessmentTest()
        End Sub

        Protected Overridable Function GetTestHelper(test As GeneralAssessmentTest) As TestHelper
            Return New TestHelper(test, _packageCreator)
        End Function

        Protected Overridable Function GetNewResourceType() As ResourceType
            Return New ResourceType
        End Function

    End Class
End Namespace