@ModelType IEnumerable(Of TestAppMVCVB.MovieEntity)

@Code
    ViewData("Title") = "Movie List"
End Code

<script src="~/Scripts/jquery-ui.min.js"></script>
<link href="~/Scripts/jquery-ui.min.css" rel="stylesheet" />

<section class="content">
    <fieldset>
        <div class="panel">
            <div class="panel-body">
                @*<div class="row" style="background-image:url(../Images/inner-heading.jpg)">
                        <div class="container">
                            <div style="margin-top: 60px"></div>
                            <div class="form-group col-lg-6 col-md-6 col-sm-6 col-xs-12" style="color: #00b6f8;">
                                <h1>Find a movie near to you...</h1>
                            </div>
                            <div class="clearfix"></div>
                            <div class="row">
                            </div>

                            <div style="margin-top: 20px"></div>
                        </div>
                    </div>

                    <div style="margin-top: 40px"></div>*@

                <div class="container">
                    <div class="input-group col-lg-12 col-md-12 col-sm-12 col-xs-12" style="color: #00b6f8;">
                        <h1>Your movie list...</h1>
                    </div>
                    @Html.ActionLink("Create New", "Create", "Home")
                    <div class="row">
                        <div>
                            <div class="clearfix"></div>
                            <div id="gridContent" style="padding: 20px;">
                                @For Each item In Model.ToList()
                                    Dim currentItem = item
                                    Dim strImage As String = "/Images/" + currentItem.Title + ".jpg"
                                    @<div class="col-sm-12">
                                        <div style="box-shadow: 0px 0px 10px 4px rgba(225, 225, 225, 0.75); padding: 20px;">
                                            <div class="col-sm-4">
                                                <img src="@strImage" style="width:150px" />
                                            </div>
                                            <div class="col-sm-4">
                                                <h3>@currentItem.Title</h3>
                                                <p>Release : @currentItem.ReleaseDate.ToString().Split(" ").FirstOrDefault()</p>
                                                <p>Category : @currentItem.Genre</p>
                                                <p>Price : @currentItem.Price</p>
                                                @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.Id}) |
                                                @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.Id})
                                            </div>
                                            <div class="col-sm-4">
                                            </div>
                                        </div>
                                    </div>

                                    @<div class="clearfix"></div>
                                    @<div style="margin-top: 20px"></div>
                                Next
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </fieldset>
</section>
