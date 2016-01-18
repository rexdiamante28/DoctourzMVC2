@Imports System.Xml

@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim rssDoc As New XmlDocument
    'rssDoc.Load("http://www.health.com/health/healthy-happy/feed")
    rssDoc.Load("https://www.nlm.nih.gov/medlineplus/feeds/news_en.xml")
    
   
    Dim xmlnode As XmlNodeList
    
    xmlnode = rssDoc.GetElementsByTagName("item")
    
   
End Code


<div class="col-sm-6 col-sm-offset-3 no-padd">
    @For i = 0 To xmlnode.Count - 1
        @<div class="col-sm-6  padd-10">
            <div class="col-xs-12 bgwhite" style="white-space: pre-wrap; word-wrap:break-word;">
                @xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                @xmlnode(i).ChildNodes.Item(1).InnerText.Trim()
                @xmlnode(i).ChildNodes.Item(2).InnerText.Trim()
                @xmlnode(i).ChildNodes.Item(3).InnerText.Trim()
                @xmlnode(i).ChildNodes.Item(4).InnerText.Trim()
            </div>
        </div>
    Next
</div>


<script>
    document.getElementById('topbar2').setAttribute("class","bggray5");
</script>
