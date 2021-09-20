<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Group_Project_WebApplication.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Us</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-banner">
      <div class="page-heading contact-heading header-text">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="text-content">
                <h4>contact us</h4>
                <h2>get in touch with us</h2>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    


    <div class="find-us">
      <div class="container-background"></div>
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="section-heading">
              <h2>Our Location on Maps</h2>
            </div>
          </div>
          <div class="col-md-8">
            <div id="map">
              <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d15172.74914698347!2d27.998827399988397!3d-26.18717490368933!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1e950b9514e0777d%3A0xff8d68c0a477737!2sKingsway%20Campus%20Auckland%20Park!5e0!3m2!1sen!2sza!4v1632087453334!5m2!1sen!2sza" width="100%" height="370" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
            </div>
          </div>
          <div class="col-md-4">
            <div class="left-content">
              <h4>About our office</h4>
              <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti.</p>
            </div>
          </div>
        </div>
      </div>
    </div>

    
    <div class="send-message">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="section-heading">
              <h2>Send us a Message</h2>
            </div>
          </div>
          <div class="col-md-8">
            <div class="contact-form">
              <form id="contact" action="" method="post">
                <div class="row">
                  <div class="col-lg-12 col-md-12 col-sm-12">
                    <fieldset>
                      <input name="name" type="text" class="form-control" id="name" placeholder="Full Name" required="">
                    </fieldset>
                  </div>
                  <div class="col-lg-12 col-md-12 col-sm-12">
                    <fieldset>
                      <input name="email" type="text" class="form-control" id="email" placeholder="E-Mail Address" required="">
                    </fieldset>
                  </div>
                  <div class="col-lg-12 col-md-12 col-sm-12">
                    <fieldset>
                      <input name="subject" type="text" class="form-control" id="subject" placeholder="Subject" required="">
                    </fieldset>
                  </div>
                  <div class="col-lg-12">
                    <fieldset>
                      <textarea name="message" rows="6" class="form-control" id="message" placeholder="Your Message" required=""></textarea>
                    </fieldset>
                  </div>
                  <div class="col-lg-12">
                    <fieldset>
                      <button type="submit" id="form-submit" class="filled-button">Send Message</button>
                    </fieldset>
                  </div>
                </div>
              </form>
            </div>
          </div>
          <div class="col-md-4">
            <ul class="accordion">
              <li>
                  <a>Accordion Title One</a>
                  <div class="content">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Second Title Here</a>
                  <div class="content">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Accordion Title Three</a>
                  <div class="content">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
              <li>
                  <a>Fourth Accordion Title</a>
                  <div class="content">
                      <p>Lorem ipsum dolor sit amet, consectetur adipisic elit. Sed voluptate nihil eumester consectetur similiqu consectetur.<br><br>Lorem ipsum dolor sit amet, consectetur adipisic elit. Et, consequuntur, modi mollitia corporis ipsa voluptate corrupti elite.</p>
                  </div>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
