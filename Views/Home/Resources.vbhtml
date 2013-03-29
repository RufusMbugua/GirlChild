@Code
    ViewData("Title") = "Resources"
End Code

<h2>Resources</h2>
<form>
    <label>Name</label>
    <input type="text" name="name"/>
    <label>Type</label>
    <select name="type">
        <option>Please Choose Type</option>
    </select>
    <label>Details</label>
    <textarea name="details">

    </textarea>
    <label>Webresource Link</label>
    <input type="url" name="weblink"/>
    <label>Upload File</label>
    <input type="file" />
    
</form>