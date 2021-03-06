﻿Namespace QTI30

    <TestClass()>
    Public Class ResponseDeclarationHottextTests
        Inherits QTI_Base.ResponseDeclarationHottextTestsBase

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub ItemWithOneHotspotInteractionAndDichotomousScoringWhenCreatingResponseDeclarationShouldCreateCorrectResponsesButNoMappings()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution1, GetHottextScoringParams(), _result1, 1)
        End Sub

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub ItemWithOneHotspotInteractionAndPolytomousScoringWhenCreatingResponseDeclarationShouldCreateCorrectResponsesAndMappings()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution6, GetHottextScoringParams(), _result6, 1)
        End Sub

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub GetResponseDeclarationForCombinationOfFactSetsAndFactsOnFindingTest()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution2, GetHottextScoringParams(), _result2, 1)
        End Sub

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub GetResponseDeclarationForMultipleFactSetsTest()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution3, GetHottextScoringParams(), _result3, 1)
        End Sub

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub GetResponseDeclarationForFactSetsTest()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution4, GetHottextScoringParams(), _result4, 1)
        End Sub

        <TestMethod(), TestCategory("Publication"), TestCategory("QTIScoring"), TestCategory("CesResponseDeclaration")>
        Public Sub GetEmptyResponseDeclarationTest()
            PublicationTestHelper.RunResponseDeclarationTest(_itemBody1, _solution5, GetHottextScoringParams(), _result5, 1)
        End Sub


        Private _itemBody1 As XElement =
           <wrapper>
               <itemBody class="defaultBody">
                   <div class="content">
                       <div>
                           <div class="div_left">
                               <!-- div_left_inner is needed to create the 50px margin between the left and right columns in dual column mode -->
                               <div class="div_left_inner">
                                   <div id="leftBody">
                                       <p id="c1-id-11"> </p>
                                   </div>
                                   <div id="questionwithinlinecontrol">
                                       <qti-hottext-interaction response-identifier="hottextController" max-choices="25">
                                           <p id="c1-id-11">
                                               <span>
                                                   <qti-hottext identifier="Iba0772fe-878f-457c-b652-a0e922626082"/>
                                               </span>
                                               <span id="SIba0772fe-878f-457c-b652-a0e922626082" style="background-color: #C7B8CE;">Op</span>
                                               <span>
                                                   <qti-hottext identifier="I5493e55f-fae9-499f-bd3e-16df52c028e1"/>
                                               </span>
                                               <span id="SI5493e55f-fae9-499f-bd3e-16df52c028e1" style="background-color: #C7B8CE;">vrijwel</span>
                                               <span>
                                                   <qti-hottext identifier="I7134c778-4641-40b5-8eae-1a80013cf777"/>
                                               </span>
                                               <span id="SI7134c778-4641-40b5-8eae-1a80013cf777" style="background-color: #C7B8CE;">alle</span>
                                               <span>
                                                   <qti-hottext identifier="I3cb9edb6-551e-474a-9122-338b8c6a396d"/>
                                               </span>
                                               <span id="SI3cb9edb6-551e-474a-9122-338b8c6a396d" style="background-color: #C7B8CE;">een</span>
                                               <span>
                                                   <qti-hottext identifier="I41d5e633-d892-46fe-8a0c-ceba54c167f3"/>
                                               </span>
                                               <span id="SI41d5e633-d892-46fe-8a0c-ceba54c167f3" style="background-color: #C7B8CE;">meren</span>
                                               <span>
                                                   <qti-hottext identifier="I498a96cd-114d-4299-b27c-639e41559e29"/>
                                               </span>
                                               <span id="SI498a96cd-114d-4299-b27c-639e41559e29" style="background-color: #C7B8CE;">is</span>
                                               <span>
                                                   <qti-hottext identifier="I19b64b54-f7f4-4284-af37-37999bd24935"/>
                                               </span>
                                               <span id="SI19b64b54-f7f4-4284-af37-37999bd24935" style="background-color: #C7B8CE;">in</span>
                                               <span>
                                                   <qti-hottext identifier="I7ea195a7-b0ec-465e-ada3-31c9e940f0dc"/>
                                               </span>
                                               <span id="SI7ea195a7-b0ec-465e-ada3-31c9e940f0dc" style="background-color: #C7B8CE;">de</span>
                                               <span>
                                                   <qti-hottext identifier="Ibf683ce7-ac85-4610-b057-dd0578f3b71f"/>
                                               </span>
                                               <span id="SIbf683ce7-ac85-4610-b057-dd0578f3b71f" style="background-color: #C7B8CE;">zomer</span>
                                               <span>
                                                   <qti-hottext identifier="Ie6f1fe1f-fe23-4f29-85ec-27d483138cfa"/>
                                               </span>
                                               <span id="SIe6f1fe1f-fe23-4f29-85ec-27d483138cfa" style="background-color: #C7B8CE;">veel</span>
                                               <span>
                                                   <qti-hottext identifier="I2b4ed71d-8984-4ffd-a95a-126efbb12e48"/>
                                               </span>
                                               <span id="SI2b4ed71d-8984-4ffd-a95a-126efbb12e48" style="background-color: #C7B8CE;">te</span>
                                               <span>
                                                   <qti-hottext identifier="I0778d3a8-11c3-41f5-aeb7-4efd94338296"/>
                                               </span>
                                               <span id="SI0778d3a8-11c3-41f5-aeb7-4efd94338296" style="background-color: #C7B8CE;">doen</span>: <span>
                                                   <qti-hottext identifier="I3a1bf3a7-f9b4-472d-ac19-c6d27f671543"/>
                                               </span>
                                               <span id="SI3a1bf3a7-f9b4-472d-ac19-c6d27f671543" style="background-color: #C7B8CE;">ze</span>
                                               <span>
                                                   <qti-hottext identifier="I01f17f48-6da9-44a0-bb7f-82e325f2f233"/>
                                               </span>
                                               <span id="SI01f17f48-6da9-44a0-bb7f-82e325f2f233" style="background-color: #C7B8CE;">zijn</span>
                                               <span>
                                                   <qti-hottext identifier="Ifdbe8e9c-0eeb-4019-b8a7-5599265834fb"/>
                                               </span>
                                               <span id="SIfdbe8e9c-0eeb-4019-b8a7-5599265834fb" style="background-color: #C7B8CE;">twee</span>
                                               <span>
                                                   <qti-hottext identifier="I0dd2d1e9-84b7-4b3f-a144-a2ec2c13061b"/>
                                               </span>
                                               <span id="SI0dd2d1e9-84b7-4b3f-a144-a2ec2c13061b" style="background-color: #C7B8CE;">geschikt</span>
                                               <span>
                                                   <qti-hottext identifier="I41e6c74d-787a-4620-889f-fae84be71cdb"/>
                                               </span>
                                               <span id="SI41e6c74d-787a-4620-889f-fae84be71cdb" style="background-color: #C7B8CE;">voor</span>
                                               <span>
                                                   <qti-hottext identifier="I1f639c54-57ee-428e-93ed-77d786d5a2d1"/>
                                               </span>
                                               <span id="SI1f639c54-57ee-428e-93ed-77d786d5a2d1" style="background-color: #C7B8CE;">drie</span>. <span>
                                                   <qti-hottext identifier="Ib580dda7-0717-4cfc-b70e-34059b4c78f1"/>
                                               </span>
                                               <span id="SIb580dda7-0717-4cfc-b70e-34059b4c78f1" style="background-color: #C7B8CE;">Met</span>
                                               <span>
                                                   <qti-hottext identifier="I834d38a6-dac5-4235-9cf4-d323dd89f1d2"/>
                                               </span>
                                               <span id="SI834d38a6-dac5-4235-9cf4-d323dd89f1d2" style="background-color: #C7B8CE;">de</span>
                                               <span>
                                                   <qti-hottext identifier="Ic858ebcf-6f25-46ee-be0b-afbee1f41971"/>
                                               </span>
                                               <span id="SIc858ebcf-6f25-46ee-be0b-afbee1f41971" style="background-color: #C7B8CE;">bovenbouw</span>
                                               <span>
                                                   <qti-hottext identifier="If6a1b756-b293-4baf-a3c0-3332221e3ea8"/>
                                               </span>
                                               <span id="SIf6a1b756-b293-4baf-a3c0-3332221e3ea8" style="background-color: #C7B8CE;">van</span>
                                               <span>
                                                   <qti-hottext identifier="I80cb35ef-89d7-4ada-aef4-eda2b963a606"/>
                                               </span>
                                               <span id="SI80cb35ef-89d7-4ada-aef4-eda2b963a606" style="background-color: #C7B8CE;">de</span>
                                               <span>
                                                   <qti-hottext identifier="Ia2c49323-f160-4dfa-8f79-5abea876efa6"/>
                                               </span>
                                               <span id="SIa2c49323-f160-4dfa-8f79-5abea876efa6" style="background-color: #C7B8CE;">vier</span>
                                               <span>
                                                   <qti-hottext identifier="I8ecdc331-d565-4fcc-9f1f-a83e6e6bab9d"/>
                                               </span>
                                               <span id="SI8ecdc331-d565-4fcc-9f1f-a83e6e6bab9d" style="background-color: #C7B8CE;">gaan</span>
                                               <span>
                                                   <qti-hottext identifier="I4142aba3-f108-41dc-b537-ab44fd8cb5ae"/>
                                               </span>
                                               <span id="SI4142aba3-f108-41dc-b537-ab44fd8cb5ae" style="background-color: #C7B8CE;">we</span>
                                               <span>
                                                   <qti-hottext identifier="If9dc68d4-33ec-4176-adb2-eda10373f1a0"/>
                                               </span>
                                               <span id="SIf9dc68d4-33ec-4176-adb2-eda10373f1a0" style="background-color: #C7B8CE;">daarom</span>
                                               <span>
                                                   <qti-hottext identifier="Ice8f6ba6-0b24-4234-8e1c-ea2d6caf18f6"/>
                                               </span>
                                               <span id="SIce8f6ba6-0b24-4234-8e1c-ea2d6caf18f6" style="background-color: #C7B8CE;">in</span>
                                               <span>
                                                   <qti-hottext identifier="Ia64d8e75-aa61-481b-bd40-df7270053448"/>
                                               </span>
                                               <span id="SIa64d8e75-aa61-481b-bd40-df7270053448" style="background-color: #C7B8CE;">de</span>
                                               <span>
                                                   <qti-hottext identifier="I2a787ac6-adce-419f-b230-293302ab6e2b"/>
                                               </span>
                                               <span id="SI2a787ac6-adce-419f-b230-293302ab6e2b" style="background-color: #C7B8CE;">vijf</span>
                                               <span>
                                                   <qti-hottext identifier="I562dc41e-1fcd-45b2-ad63-e346a9b12ed3"/>
                                               </span>
                                               <span id="SI562dc41e-1fcd-45b2-ad63-e346a9b12ed3" style="background-color: #C7B8CE;">een</span>
                                               <span>
                                                   <qti-hottext identifier="I2ff56de9-53fd-4be6-adc3-b9d48cbac0bd"/>
                                               </span>
                                               <span id="SI2ff56de9-53fd-4be6-adc3-b9d48cbac0bd" style="background-color: #C7B8CE;">weekje</span>
                                               <span>
                                                   <qti-hottext identifier="I8c49dcaf-eea6-48ad-bcf0-5c00ccde0415"/>
                                               </span>
                                               <span id="SI8c49dcaf-eea6-48ad-bcf0-5c00ccde0415" style="background-color: #C7B8CE;">naar</span>
                                               <span>
                                                   <qti-hottext identifier="I7b431d95-a30e-403f-9b35-7575b30d31a3"/>
                                               </span>
                                               <span id="SI7b431d95-a30e-403f-9b35-7575b30d31a3" style="background-color: #C7B8CE;">het</span>
                                               <span>
                                                   <qti-hottext identifier="I46f0651d-a9f2-4b96-8172-8104b0938213"/>
                                               </span>
                                               <span id="SI46f0651d-a9f2-4b96-8172-8104b0938213" style="background-color: #C7B8CE;">zes</span>. <span>
                                                   <qti-hottext identifier="I1e40e819-c8a2-42dd-89de-dd29e070b99b"/>
                                               </span>
                                               <span id="SI1e40e819-c8a2-42dd-89de-dd29e070b99b" style="background-color: #C7B8CE;">Waarschijnlijk</span>
                                               <span>
                                                   <qti-hottext identifier="I67b6042e-7444-46be-b169-53ec421f9eda"/>
                                               </span>
                                               <span id="SI67b6042e-7444-46be-b169-53ec421f9eda" style="background-color: #C7B8CE;">gaan</span>
                                               <span>
                                                   <qti-hottext identifier="I18248834-8320-4342-967c-2007195ba14a"/>
                                               </span>
                                               <span id="SI18248834-8320-4342-967c-2007195ba14a" style="background-color: #C7B8CE;">de</span>
                                               <span>
                                                   <qti-hottext identifier="I0bf4350c-9288-4cec-9e37-1b0978b057ba"/>
                                               </span>
                                               <span id="SI0bf4350c-9288-4cec-9e37-1b0978b057ba" style="background-color: #C7B8CE;">Heer</span>
                                               <span>
                                                   <qti-hottext identifier="Ifb1bfeea-20a0-4d29-bb87-d502ff355522"/>
                                               </span>
                                               <span id="SIfb1bfeea-20a0-4d29-bb87-d502ff355522" style="background-color: #C7B8CE;">acht</span>
                                               <span>
                                                   <qti-hottext identifier="Ie1f531cd-79c9-4b87-a90c-76766792b183"/>
                                               </span>
                                               <span id="SIe1f531cd-79c9-4b87-a90c-76766792b183" style="background-color: #C7B8CE;">en</span>
                                               <span>
                                                   <qti-hottext identifier="I66faad9a-d004-4cdc-a275-6f9ff736bb14"/>
                                               </span>
                                               <span id="SI66faad9a-d004-4cdc-a275-6f9ff736bb14" style="background-color: #C7B8CE;">negen</span>
                                               <span>
                                                   <qti-hottext identifier="I665f2702-e926-4266-bc3c-3f04ea9a6c62"/>
                                               </span>
                                               <span id="SI665f2702-e926-4266-bc3c-3f04ea9a6c62" style="background-color: #C7B8CE;">tien</span> - <span>
                                                   <qti-hottext identifier="I7e8b004a-0223-432a-bb9a-536918190017"/>
                                               </span>
                                               <span id="SI7e8b004a-0223-432a-bb9a-536918190017" style="background-color: #C7B8CE;">van</span>
                                               <span>
                                                   <qti-hottext identifier="I217873b0-4970-405f-a80b-b2a9f42bbd85"/>
                                               </span>
                                               <span id="SI217873b0-4970-405f-a80b-b2a9f42bbd85" style="background-color: #C7B8CE;">der</span>
                                               <span>
                                                   <qti-hottext identifier="I46521597-f1f4-432c-96c2-8e3defb05950"/>
                                               </span>
                                               <span id="SI46521597-f1f4-432c-96c2-8e3defb05950" style="background-color: #C7B8CE;">wielen</span>
                                               <span>
                                                   <qti-hottext identifier="Ifbea86b5-20bc-4dde-a4e4-4a14153c8ead"/>
                                               </span>
                                               <span id="SIfbea86b5-20bc-4dde-a4e4-4a14153c8ead" style="background-color: #C7B8CE;">mee</span>
                                               <span>
                                                   <qti-hottext identifier="I279d3c47-95a8-42d1-9440-26fadf909090"/>
                                               </span>
                                               <span id="SI279d3c47-95a8-42d1-9440-26fadf909090" style="background-color: #C7B8CE;">als</span>
                                               <span>
                                                   <qti-hottext identifier="I6d80a45f-5042-4f42-99fe-151229268a43"/>
                                               </span>
                                               <span id="SI6d80a45f-5042-4f42-99fe-151229268a43" style="background-color: #C7B8CE;">begeleider</span>.</p>
                                       </qti-hottext-interaction>
                                   </div>
                               </div>
                           </div>
                           <div class="div_right">
                               <!-- div_right_inner is needed to create the 50px margin between the left and right columns in dual column mode -->
                               <div class="div_right_inner">
                                   <div id="body">
                                       <p id="c1-id-11">In de ...</p>
                                   </div>
                                   <div id="question">
                                       <p id="c1-id-11" class="UserSRVet">Klik ...</p>
                                   </div>
                                   <div id="itemgeneral">
                                       <br/>
                                       <p id="c1-id-11"> </p>
                                   </div>
                               </div>
                           </div>
                       </div>
                   </div>
               </itemBody>
           </wrapper>



        Private _result1 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="identifier">
                    <qti-correct-response interpretation="I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1&amp;I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I46f0651d-a9f2-4b96-8172-8104b0938213&amp;I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950">
                        <qti-value>I3cb9edb6-551e-474a-9122-338b8c6a396d</qti-value>
                        <qti-value>I1f639c54-57ee-428e-93ed-77d786d5a2d1</qti-value>
                        <qti-value>I2a787ac6-adce-419f-b230-293302ab6e2b</qti-value>
                        <qti-value>I46f0651d-a9f2-4b96-8172-8104b0938213</qti-value>
                        <qti-value>I0bf4350c-9288-4cec-9e37-1b0978b057ba</qti-value>
                        <qti-value>I665f2702-e926-4266-bc3c-3f04ea9a6c62</qti-value>
                        <qti-value>I46521597-f1f4-432c-96c2-8e3defb05950</qti-value>
                    </qti-correct-response>
                </qti-response-declaration>
            </root>

        Private _result2 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="identifier">
                    <qti-correct-response interpretation="I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1&amp;(I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I46f0651d-a9f2-4b96-8172-8104b0938213)|I46f0651d-a9f2-4b96-8172-8104b0938213|I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950">
                        <qti-value>I3cb9edb6-551e-474a-9122-338b8c6a396d</qti-value>
                        <qti-value>I1f639c54-57ee-428e-93ed-77d786d5a2d1</qti-value>
                        <qti-value>I2a787ac6-adce-419f-b230-293302ab6e2b</qti-value>
                        <qti-value>I46f0651d-a9f2-4b96-8172-8104b0938213</qti-value>
                        <qti-value>I0bf4350c-9288-4cec-9e37-1b0978b057ba</qti-value>
                        <qti-value>I665f2702-e926-4266-bc3c-3f04ea9a6c62</qti-value>
                        <qti-value>I46521597-f1f4-432c-96c2-8e3defb05950</qti-value>
                    </qti-correct-response>
                </qti-response-declaration>
            </root>

        Private _result3 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="identifier">
                    <qti-correct-response interpretation="(I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1)&amp;(I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I46f0651d-a9f2-4b96-8172-8104b0938213)|I46f0651d-a9f2-4b96-8172-8104b0938213|I2a787ac6-adce-419f-b230-293302ab6e2b&amp;(I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950)|(I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I7e8b004a-0223-432a-bb9a-536918190017&amp;I46521597-f1f4-432c-96c2-8e3defb05950)">
                        <qti-value>I3cb9edb6-551e-474a-9122-338b8c6a396d</qti-value>
                        <qti-value>I1f639c54-57ee-428e-93ed-77d786d5a2d1</qti-value>
                        <qti-value>I2a787ac6-adce-419f-b230-293302ab6e2b</qti-value>
                        <qti-value>I46f0651d-a9f2-4b96-8172-8104b0938213</qti-value>
                        <qti-value>I0bf4350c-9288-4cec-9e37-1b0978b057ba</qti-value>
                        <qti-value>I665f2702-e926-4266-bc3c-3f04ea9a6c62</qti-value>
                        <qti-value>I46521597-f1f4-432c-96c2-8e3defb05950</qti-value>
                    </qti-correct-response>
                </qti-response-declaration>
            </root>

        Private _result4 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="identifier">
                    <qti-correct-response interpretation="(I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1&amp;I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I46f0651d-a9f2-4b96-8172-8104b0938213&amp;I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950)|(I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1&amp;Ia2c49323-f160-4dfa-8f79-5abea876efa6&amp;I46f0651d-a9f2-4b96-8172-8104b0938213&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950)">
                        <qti-value>I3cb9edb6-551e-474a-9122-338b8c6a396d</qti-value>
                        <qti-value>I1f639c54-57ee-428e-93ed-77d786d5a2d1</qti-value>
                        <qti-value>I2a787ac6-adce-419f-b230-293302ab6e2b</qti-value>
                        <qti-value>I46f0651d-a9f2-4b96-8172-8104b0938213</qti-value>
                        <qti-value>I0bf4350c-9288-4cec-9e37-1b0978b057ba</qti-value>
                        <qti-value>I665f2702-e926-4266-bc3c-3f04ea9a6c62</qti-value>
                        <qti-value>I46521597-f1f4-432c-96c2-8e3defb05950</qti-value>
                    </qti-correct-response>
                </qti-response-declaration>
            </root>

        Private _result5 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="string"/>
            </root>

        Private _result6 As XElement =
            <root>
                <qti-response-declaration identifier="RESPONSE" cardinality="multiple" base-type="identifier">
                    <qti-correct-response interpretation="I3cb9edb6-551e-474a-9122-338b8c6a396d&amp;I1f639c54-57ee-428e-93ed-77d786d5a2d1&amp;I2a787ac6-adce-419f-b230-293302ab6e2b&amp;I46f0651d-a9f2-4b96-8172-8104b0938213&amp;I0bf4350c-9288-4cec-9e37-1b0978b057ba&amp;I665f2702-e926-4266-bc3c-3f04ea9a6c62&amp;I46521597-f1f4-432c-96c2-8e3defb05950">
                        <qti-value>I3cb9edb6-551e-474a-9122-338b8c6a396d</qti-value>
                        <qti-value>I1f639c54-57ee-428e-93ed-77d786d5a2d1</qti-value>
                        <qti-value>I2a787ac6-adce-419f-b230-293302ab6e2b</qti-value>
                        <qti-value>I46f0651d-a9f2-4b96-8172-8104b0938213</qti-value>
                        <qti-value>I0bf4350c-9288-4cec-9e37-1b0978b057ba</qti-value>
                        <qti-value>I665f2702-e926-4266-bc3c-3f04ea9a6c62</qti-value>
                        <qti-value>I46521597-f1f4-432c-96c2-8e3defb05950</qti-value>
                    </qti-correct-response>
                    <qti-mapping>
                        <qti-map-entry map-key="I3cb9edb6-551e-474a-9122-338b8c6a396d" mapped-value="1"/>
                        <qti-map-entry map-key="I1f639c54-57ee-428e-93ed-77d786d5a2d1" mapped-value="1"/>
                        <qti-map-entry map-key="I2a787ac6-adce-419f-b230-293302ab6e2b" mapped-value="1"/>
                        <qti-map-entry map-key="I46f0651d-a9f2-4b96-8172-8104b0938213" mapped-value="1"/>
                        <qti-map-entry map-key="I0bf4350c-9288-4cec-9e37-1b0978b057ba" mapped-value="1"/>
                        <qti-map-entry map-key="I665f2702-e926-4266-bc3c-3f04ea9a6c62" mapped-value="1"/>
                        <qti-map-entry map-key="I46521597-f1f4-432c-96c2-8e3defb05950" mapped-value="1"/>
                    </qti-mapping>
                </qti-response-declaration>
            </root>


    End Class

End Namespace