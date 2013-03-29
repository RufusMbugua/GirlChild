@Code
    ViewData("Title") = "Home Page"
End Code
<script type="text/javascript">
    function GetMap() {
        var map = new Microsoft.Maps.Map(document.getElementById("mapDiv"), { credentials: "ApUXIBEcEPJ9hdhz7tGNzmBJ9v9dGQwFHYqbxjCRLM4PHgaeoq79i6XTSixhmyWH", center: new Microsoft.Maps.Location(1.2833, 36.8167),
            mapTypeId: Microsoft.Maps.MapTypeId.road, showScalebar: false, zoom: 6 });

    }
</script>
<div id="mapDiv" class="map"></div>

<h2>Recent Reports</h2>
<section class="recent-reports">
    <article>
        <h3>Article 1</h3>
    </article>
    

    <article>
        <h3>Article 2</h3>
    </article>
    <article>
        <h3>Article 3</h3>
    </article>
</section>