Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Modify this template to jump-start your ASP.NET MVC application."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your app description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Report() As ActionResult
        ViewData("Message") = "Fill in a report."

        Return View()
    End Function

    Function Partners() As ActionResult
        ViewData("Message") = "View List of partners."

        Return View()
    End Function

    Function Resources() As ActionResult
        ViewData("Message") = "List of Resources."

        Return View()
    End Function
End Class
