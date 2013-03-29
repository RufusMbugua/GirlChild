@Code
    ViewData("Title") = "Partners"
End Code

<h2>Partners</h2>
<form>
    <label>Category</label>
    <select name="category">
       <option>Please Choose Category</option> 
    </select>
    <label>Website</label>
    <input type="url" name="website"/>
    <label>Name</label>
    <input type="text" name="name"/>
    <label>Logo</label>
    <input type="file" name="logo"/>
</form>
