#pragma checksum "C:\Users\Lenovo\source\repos\visit_Japan\visit_Japan\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "692b34a4be97d6e104272e59d0e36686c6c71339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(visit_Japan.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace visit_Japan.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\visit_Japan\visit_Japan\Pages\_ViewImports.cshtml"
using visit_Japan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"692b34a4be97d6e104272e59d0e36686c6c71339", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7862901ada74a886fd70e19f3af254881fa8a17", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/flag.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:450px;width:650px;border-radius:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("isAuth()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\visit_Japan\visit_Japan\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Hero Section ======= -->
<section id=""hero"">
    <div id=""heroCarousel"" data-bs-interval=""3000"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel"">

        <ol class=""carousel-indicators"" id=""hero-carousel-indicators""></ol>

        <div class=""carousel-inner"" role=""listbox"">

            <!-- Slide 1 -->
            <div class=""carousel-item active"" style=""background-image: url(assets/img/slide/pic1.jpg)"">
                <div class=""carousel-container"">
                    <div class=""container"">
                        <h2 class=""animate__animated animate__fadeInDown"">Welcome to <span>Japan</span></h2>
                        <p class=""animate__animated animate__fadeInUp"">One of the most beautiful countries in the world</p>
                        <a href=""https://en.wikipedia.org/wiki/Japan"" target=""_blank"" class=""btn-get-started animate__animated animate__fadeInUp scrollto"">Read More</a>
                    </div>
                </div>
            </div>

   ");
            WriteLiteral(@"         <!-- Slide 2 -->
            <div class=""carousel-item"" style=""background-image: url(assets/img/slide/pic2.jpg)"">
                <div class=""carousel-container"">
                    <div class=""container"">
                        <h2 class=""animate__animated animate__fadeInDown"">You will find the culture here</h2>
                        <p class=""animate__animated animate__fadeInUp"">Japan is rich in culture that you will enjoy knowing it</p>
                        <a href=""https://en.wikipedia.org/wiki/Japan"" target=""_blank"" class=""btn-get-started animate__animated animate__fadeInUp scrollto"">Read More</a>
                    </div>
                </div>
            </div>

            <!-- Slide 3 -->
            <div class=""carousel-item"" style=""background-image: url(assets/img/slide/pic3.jpg)"">
                <div class=""carousel-container"">
                    <div class=""container"">
                        <h2 class=""animate__animated animate__fadeInDown"">Say yes for fun</h2>");
            WriteLiteral(@"
                        <p class=""animate__animated animate__fadeInUp"">There are a lot of things waiting you here</p>
                        <a href=""https://en.wikipedia.org/wiki/Japan"" target=""_blank"" class=""btn-get-started animate__animated animate__fadeInUp scrollto"">Read More</a>
                    </div>
                </div>
            </div>

        </div>

        <a class=""carousel-control-prev"" href=""#heroCarousel"" role=""button"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon bi bi-chevron-left"" aria-hidden=""true""></span>
        </a>

        <a class=""carousel-control-next"" href=""#heroCarousel"" role=""button"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon bi bi-chevron-right"" aria-hidden=""true""></span>
        </a>

    </div>
</section><!-- End Hero -->

<main id=""main"">

    <!-- ======= About Us Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"">

            <div class=""s");
            WriteLiteral(@"ection-title"">
                <h2>About Japan</h2>
                <p>Visit Japan is a tourism company, The idea Started with the founder and CEO of Visit Japan, Mahmoud Alaishat in 2022 and decided to bring the idea to life as soon as he can and here we are.</p>
            </div>

            <div class=""row"">
                <div class=""col-lg-6 order-1 order-lg-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "692b34a4be97d6e104272e59d0e36686c6c713399462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0 order-2 order-lg-1 content"">
                    <h3 style=""padding-bottom:3px"">Japan history</h3>

                    <p style=""padding-bottom: 4px; color: #BC002D"">
                        It is situated in the northwest Pacific Ocean, and is bordered on the west by the Sea of Japan, while extending from the Sea of Okhotsk in the north toward the East China Sea and Taiwan in the south
                    </p>
                    <ul>
                        <li><i class=""bi bi-check-circled""></i> Japan is a part of the Ring of Fire, and spans an archipelago of 6852 islands covering 377,975 square kilometers (145,937 sq mi); the five main islands are Hokkaido, Honshu (the ""mainland""), Shikoku, Kyushu, and Okinawa. Tokyo is the nation's capital and largest city; other major cities include Yokohama, Osaka, Nagoya, Sapporo, Fukuoka, Kobe, and Kyoto</li>
                        <li><i class=""bi bi-check-circled""></i> Japan is th");
            WriteLiteral(@"e eleventh most populous country in the world, as well as one of the most densely populated and urbanized. About three-fourths of the country's terrain is mountainous, concentrating its population of 125.5 million on narrow coastal plains</li>
                    </ul>
                    <p style=""color: #BC002D"">
                        Japan is divided into 47 administrative prefectures and eight traditional regions
                    </p>


                </div>

            </div>
            <div class=""card w-75 mt-3 mb-2 pt-2 pl-1 pb-1"" style=""background: rgb(188,0,45); background: linear-gradient(90deg, rgba(204,0,45,1) 0%, rgba(188,0,45,1) 63%); color: white; border-color: transparent"">
                <div class=""card-body"">
                    <blockquote class=""blockquote mb-0"">
                        <div class=""blockquote-custom-icon bg-transparent shadow-sm""><i class=""fa fa-quote-left text-white""></i></div>
                        <p style=""color: white; font-weight: bold; fon");
            WriteLiteral(@"t-style: italic; padding-bottom: 6px; padding-top: 9px; background-color: transparent; width: fit-content; border-radius: 5px; font-family: 'Times New Roman', Times, serif; font-size: 18px;word-spacing:3px"">
                            七転び八起き,Nanakorobi yaoki<br />When life knocks you down, stand back up; What matters is not the bad that happened, but what one does after
                        </p>
                        <p style=""color: white; margin-top: 8px; font-style: italic; font-family: Cambria, Cochin, Georgia, Times, Times New Roman, serif;"">Someone</p>
                    </blockquote>
                </div>
            </div>
        </div>
    </section><!-- End About Us Section -->
    <!-- ======= Why Us Section ======= -->
    <section id=""why-us"" class=""why-us"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Reasons to visit japan</h2>
            </div>

            <div class=""row no-gutters"">

                <div class=""col");
            WriteLiteral(@"-lg-4 col-md-6 content-item"">
                    <span>01</span>
                    <h4>Safety</h4>
                    <p>Japan is amongst the safest countries in the world, with an extremely low crime rate</p>
                </div>

                <div class=""col-lg-4 col-md-6 content-item"">
                    <span>02</span>
                    <h4>Beautiful temples, shrines, and zen gardens</h4>
                    <p>There are an estimated 80,000 temples and shrines in Japan of all sizes and some are over 1,000 years old</p>
                </div>

                <div class=""col-lg-4 col-md-6 content-item"">
                    <span>03</span>
                    <h4>Clean country</h4>
                    <p>Something that you will soon notice after your arrival; Japan is extremely clean! Even in the metropole of Tokyo you will not often see trash laying around</p>
                </div>

                <div class=""col-lg-4 col-md-6 content-item"">
                    <span>04</sp");
            WriteLiteral(@"an>
                    <h4>Sakura</h4>
                    <p>Sakura presents the arrival of spring, a time for renewal and optimism</p>
                </div>

                <div class=""col-lg-4 col-md-6 content-item"">
                    <span>05</span>
                    <h4>Unique accommodation</h4>
                    <p>apan is home to a large number of Western-style hotels, but something that you should not miss out on is staying at the traditional Japanese <a href=""https://blog.japanwondertravel.com/complete-guide-to-ryokan-26906"" target=""_blank"">ryokan</a></p>
                </div>

                <div class=""col-lg-4 col-md-6 content-item"">
                    <span>06</span>
                    <h4>Friendly people</h4>
                    <p>Everyone is as respectful as possible and also incredibly helpful. If you have a question or seem to be confused about something you will always find someone who can help you</p>
                </div>

            </div>

        </div");
            WriteLiteral(@">
    </section><!-- End Why Us Section -->
    <!-- ======= Cta Section ======= -->
    <section id=""cta"" class=""cta"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-9 text-center text-lg-start"">
                    <h3 style=""font-size:35px"">Book Now</h3>
                    <p style=""font-size:17px;margin-top:3px"">Ready for the next adventure? Book your trip with us now with a few easy steps.</p>
                </div>
                <div class=""col-lg-3 cta-btn-container text-center"">
                    <a style=""font-size:17px"" class=""cta-btn align-middle col-7"" href=""#"">Apply</a>
                </div>
            </div>

        </div>
    </section><!-- End Cta Section -->
    <!-- ======= Team Section ======= -->
    <section id=""team"" class=""team section-bg"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Places to visit</h2>
                <p>
                    There are ma");
            WriteLiteral(@"ny places you can visit in Japan check your favorite place now
                </p>
            </div>

            <div class=""row"">
                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        <img src=""assets/img/places/Sankeiengraden.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10121, "\"", 10127, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h4>Sankeien Garden</h4>
                        <span>Sankeien Garden is a Japanese garden in Yokohama</span>

                        <div class=""social"">
                            <a href=""https://www.sankeien.or.jp/en/history/"" target=""_blank""><i class=""bi bi-heart""></i></a>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        <img src=""assets/img/places/senso-ji.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10711, "\"", 10717, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h4>Sensō-ji</h4>
                        <span>Sensō-ji is an ancient Buddhist temple located in Asakusa, Tokyo</span>

                        <div class=""social"">
                            <a href=""https://en.wikipedia.org/wiki/Sens%C5%8D-ji"" target=""_blank""><i class=""bi bi-heart""></i></a>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""member"">
                        <img src=""assets/img/places/churaumi-aquarium.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11324, "\"", 11330, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h4>Okinawa Churaumi Aquarium</h4>
                        <span>Okinawa Churaumi Aquarium is located within the Ocean Expo Park in Okinawa</span>

                        <div class=""social"">
                            <a href=""https://en.wikipedia.org/wiki/Okinawa_Churaumi_Aquarium"" target=""_blank""><i class=""bi bi-heart""></i></a>
                        </div>
                    </div>
                </div>

            </div>
            <div class=""section-title mt-1"">
                <a style=""font-size:17px"" class=""btn btn-secondary align-middle col-2 mb-0"" href=""#"">See more</a>
            </div>
        </div>
    </section><!-- End Team Section -->
    <!-- ======= Contact Section ======= -->
    <section id=""contact"" class=""contact"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Contact Us</h2>
                <p>Don't hesitate to reach us here and we will back to you as soon as possible.</p>
         ");
            WriteLiteral(@"   </div>

            <div class=""row"">

                <div class=""col-lg-5 d-flex align-items-stretch"">
                    <div class=""info"">
                        <div class=""address"">
                            <i class=""bi bi-geo-alt""></i>
                            <h4>Location:</h4>
                            <p>
                                The Boulevard, Amman, Jordan
                            </p>
                        </div>

                        <div class=""email"">
                            <i class=""bi bi-envelope""></i>
                            <h4>Email:</h4>
                            <p>info@visitjapan.com</p>
                        </div>

                        <div class=""phone"">
                            <i class=""bi bi-phone""></i>
                            <h4>Call:</h4>
                            <p>+962 781674722</p>
                        </div>
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!");
            WriteLiteral(@"1m3!1d3384.8679475945823!2d35.90304175082937!3d31.96447898113287!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x151ca06e1969884d%3A0xbaf0e790ffe8b689!2sThe%20Boulevard!5e0!3m2!1sen!2sbg!4v1635943183812!5m2!1sen!2sbg"" frameborder=""0"" style=""border:0; width: 100%; height: 290px;"" allowfullscreen></iframe>
                    </div>

                </div>

                <div class=""col-lg-7 mt-5 mt-lg-0 d-flex align-items-stretch"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692b34a4be97d6e104272e59d0e36686c6c7133921766", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""form-group col-md-6"">
                                <label for=""name"">Your Name</label>
                                <input type=""text"" name=""name"" class=""form-control"" id=""name"" required>
                            </div>
                            <div class=""form-group col-md-6 mt-3 mt-md-0"">
                                <label for=""name"">Your Email</label>
                                <input type=""email"" class=""form-control"" name=""email"" id=""email"" required>
                            </div>
                        </div>
                        <div class=""form-group mt-3"">
                            <label for=""name"">Subject</label>
                            <input type=""text"" class=""form-control"" name=""subject"" id=""subject"" required>
                        </div>
                        <div class=""form-group mt-3"">
                            <label for=""message"">Message</label>
      ");
                WriteLiteral(@"                      <textarea class=""form-control"" id=""message"" name=""message"" rows=""10"" required></textarea>
                        </div>
                        <div class=""my-3"">
                            <div id=""error-message"" class=""alert alert-danger"" style=""display:none"">Your are not authenticate</div>
                            <div id=""sent-message"" class=""alert alert-success"" style=""display:none"">Your message has been sent. Thank you!</div>
                        </div>
                        <div class=""text-center""><button type=""submit"">Send Message</button></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

            </div>

        </div>
    </section><!-- End Contact Section -->

</main><!-- End #main -->
<script>

    var nameInput = document.getElementById('name');
    var emailInput = document.getElementById('email');
    var subjectInput = document.getElementById('subject');
    var messageTextArea = document.getElementById('message');
    var name = 'MAHMOUD';
    var pass = 'ALAISHAT39@GMAIL.COM';
    var form = document.getElementsByClassName('php-email-form');

    nameInput.addEventListener('focusout', myFunction);
    emailInput.addEventListener('focusout', myFunction1);
    subjectInput.addEventListener('focusout', myFunction2);
    messageTextArea.addEventListener('focusout', myFunction3);

    function isAuth() {
        var notAuth = document.getElementById('error-message');
        var auth = document.getElementById('sent-message');
        if ((nameInput.value == name) & (emailInput.value == pass)) {
            auth.style.display = ""block");
            WriteLiteral(@""";
            notAuth.style.display = ""none"";
        }
        else {
            notAuth.style.display = ""block"";
            auth.style.display = ""none"";
        }
    }
    function myFunction() {
        nameInput.value = nameInput.value.toUpperCase();
        nameInput.style.color = ""#4d4dff"";
    }
    function myFunction1() {
        emailInput.value = emailInput.value.toUpperCase();
        emailInput.style.color = ""#4d4dff"";
    }
    function myFunction2() {
        subjectInput.value = subjectInput.value.toUpperCase();
        subjectInput.style.color = ""#4d4dff"";
    }
    function myFunction3() {
        messageTextArea.value = messageTextArea.value.toUpperCase();
        messageTextArea.style.color = ""#4d4dff"";
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
