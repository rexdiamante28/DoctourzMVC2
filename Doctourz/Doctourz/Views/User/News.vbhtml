@Imports System.Xml

@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim rssDoc As New XmlDocument
    rssDoc.Load("http://www.health.com/health/healthy-happy/feed")
    'rssDoc.Load("https://www.nlm.nih.gov/medlineplus/feeds/news_en.xml")
    
   
    Dim xmlnode As XmlNodeList
    
    xmlnode = rssDoc.GetElementsByTagName("item")
    
    Dim nodeCount As Integer
    nodeCount = xmlnode.Count - 1
    Dim half As Integer = (nodeCount / 2)
   
End Code


<div class="col-sm-6 col-sm-offset-3 no-padd">
        <div class="col-sm-6  padd-10">
            @For i = 0 To half
                @<div class="col-xs-12 bgwhite top-20" style="white-space: pre-wrap; word-wrap:break-word;">
                    <text class="bold custom-fblue _17 pull-left text-center">@xmlnode(i).ChildNodes.Item(0).InnerText.Trim()</text><br /><br />
                    @xmlnode(i).ChildNodes.Item(6).InnerText.Trim()
                    <img class="col-xs-12" src="@xmlnode(i).ChildNodes.Item(8).ChildNodes.Item(0).Attributes(0).InnerText" />
                    <a target="_blank" class="pull-right _15 bold" href="@xmlnode(i).ChildNodes.Item(1).InnerText.Trim()">See more...</a>
                    <br /><text class="pull-right text-muted _12">@xmlnode(i).ChildNodes.Item(2).InnerText.Trim()</text>
                </div>
            Next
        </div>

        <div class="col-sm-6  padd-10">
            @For i = half To nodeCount
                @<div class="col-xs-12 bgwhite top-20" style="white-space: pre-wrap; word-wrap:break-word;">
                    <text class="bold custom-fblue _17 pull-left text-center">@xmlnode(i).ChildNodes.Item(0).InnerText.Trim()</text><br /><br />
                    @xmlnode(i).ChildNodes.Item(6).InnerText.Trim()
                     <img class="col-xs-12" src="@xmlnode(i).ChildNodes.Item(8).ChildNodes.Item(0).Attributes(0).InnerText" />
                    <a target="_blank" class="pull-right _15 bold" href="@xmlnode(i).ChildNodes.Item(1).InnerText.Trim()">See more...</a>
                    <br /><text class="pull-right text-muted _12">@xmlnode(i).ChildNodes.Item(2).InnerText.Trim()</text>
                </div>
            Next
        </div>
</div>


<script>
    document.getElementById('topbar2').setAttribute("class","bggray5");
</script>
