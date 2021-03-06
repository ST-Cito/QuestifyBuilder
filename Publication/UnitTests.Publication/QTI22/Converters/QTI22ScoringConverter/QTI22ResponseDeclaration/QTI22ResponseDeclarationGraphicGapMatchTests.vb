﻿<TestClass()>
Public Class QTI22ResponseDeclarationGraphicGapMatchTests
    Inherits QTI_Base.ResponseDeclarationGraphicGapMatchTestsBase

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetResponseDeclarationForCombinationOfFactSetsAndFactsOnFindingTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution1, GetGGMScoringParams, _result1, 1)
    End Sub

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetResponseDeclarationForMultipleFactSetsTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution2, GetGGMScoringParams, _result2, 1)
    End Sub

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetResponseDeclarationForFactSetsTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution3, GetGGMScoringParams, _result3, 1)
    End Sub

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetResponseDeclarationForFactsOnFindingTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution4, GetGGMScoringParams, _result4, 1)
    End Sub

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetEmptyResponseDeclarationTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution5, GetGGMScoringParams, _result5, 1)
    End Sub

    <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
    Public Sub GetResponseDeclarationWithNoValueTest()
        QTI22PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution6, GetGGMScoringParams, _result6, 1)
    End Sub


    Private _itemBody1 As XElement =
       <wrapper>
           <itemBody class="defaultBody">
               <div class="content">
                   <div>
                       <div>
                           <graphicGapMatchInteraction responseIdentifier="gapMatchController">
                               <object type="image/jpeg" data="resource://package/UK.jpg" width="197" height="256"/>
                               <gapImg identifier="A" matchMax="1" class="">
                                   <object type="image/png" data="resource://package/InlineChoice.png" class="hotspot_opacity" width="68" height="21"/>
                               </gapImg>
                               <gapImg identifier="B" matchMax="1" class="">
                                   <object type="image/jpeg" data="resource://package/hotspotimage_120_30_0_bla di bla.png"/>
                               </gapImg>
                               <gapImg identifier="C" matchMax="1" class="">
                                   <object type="image/png" data="resource://package/hsmathml_120_30_0_MFI_2014814_15_3_34_924.png"/>
                               </gapImg>
                               <gapImg identifier="D" matchMax="1" class="">
                                   <object type="image/jpeg" data="resource://package/hotspotimage_120_30_0_fsfs.png"/>
                               </gapImg>
                               <associableHotspot identifier="HSA" matchMax="1" coords="45,70,159,176" shape="rect"/>
                               <associableHotspot identifier="HSB" matchMax="1" coords="198,40,278,182" shape="rect"/>
                               <associableHotspot identifier="HSC" matchMax="1" coords="291,67,431,173" shape="rect"/>
                               <associableHotspot identifier="HSD" matchMax="1" coords="452,100,548,204" shape="rect"/>
                           </graphicGapMatchInteraction>
                       </div>
                   </div>
               </div>
           </itemBody>
       </wrapper>



    Private _result1 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="directedPair">
                <correctResponse interpretation="(D HSA&amp;C HSB)|(C HSA&amp;D HSB)&amp;B HSC&amp;A HSD">
                    <value>D HSA</value>
                    <value>C HSB</value>
                    <value>B HSC</value>
                    <value>A HSD</value>
                </correctResponse>
            </responseDeclaration>
        </responseDeclarations>

    Private _result2 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="directedPair">
                <correctResponse interpretation="(D HSA&amp;C HSB)|(C HSA&amp;D HSB)&amp;(B HSC&amp;A HSD)|(A HSC&amp;B HSD)">
                    <value>D HSA</value>
                    <value>C HSB</value>
                    <value>B HSC</value>
                    <value>A HSD</value>
                </correctResponse>
            </responseDeclaration>
        </responseDeclarations>

    Private _result3 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="directedPair">
                <correctResponse interpretation="(A HSA&amp;B HSB&amp;C HSC&amp;D HSD)|(D HSA&amp;C HSB&amp;B HSC&amp;A HSD)">
                    <value>A HSA</value>
                    <value>B HSB</value>
                    <value>C HSC</value>
                    <value>D HSD</value>
                </correctResponse>
            </responseDeclaration>
        </responseDeclarations>

    Private _result4 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="directedPair">
                <correctResponse interpretation="D HSA&amp;C HSB&amp;B HSC&amp;A HSD">
                    <value>D HSA</value>
                    <value>C HSB</value>
                    <value>B HSC</value>
                    <value>A HSD</value>
                </correctResponse>
            </responseDeclaration>
        </responseDeclarations>

    Private _result5 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="string"/>
        </responseDeclarations>

    Private _result6 As XElement =
        <responseDeclarations>
            <responseDeclaration identifier="RESPONSE" cardinality="multiple" baseType="directedPair">
                <correctResponse interpretation="(D HSA&amp;Ø HSB)|(Ø HSA&amp;D HSB)&amp;Ø HSC&amp;A HSD">
                    <value>D HSA</value>
                    <value>A HSD</value>
                </correctResponse>
            </responseDeclaration>
        </responseDeclarations>


End Class
