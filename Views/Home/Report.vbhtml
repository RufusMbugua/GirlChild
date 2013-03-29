@Code
    ViewData("Title") = "Report"
End Code

<h2>Report</h2>

<form>
    <label>Location</label>
    <input type="text" name="location" placeholder="e.g Nairobi"/>
    <label>Name</label>
    <input type="text" name="name" placeholder="e.g John Doe"/>
    <label>Email Address</label>
    <input type="email" name="email" placeholder="user@example.com"/>
    <label>Story</label>
    <textarea name="story" placeholder="Write story here..."></textarea>
    <label>Category</label>
    <select name="category">
        <option>Please Choose Category</option>
        <option>Success</option>
        <option>Discrimination</option>

    </select>
    <label>Add Image</label>
    <input type="file" name="image" accept="image/jpg,image/gif,image/png" />
    <input type="submit" name="submit" value="Report"/>
</form>