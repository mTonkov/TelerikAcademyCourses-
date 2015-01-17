


(function () {
    var words = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];
    var fill = d3.scale.category20();
    wordmap = {};
    words.map(function (d) {
        word_list = d.split(' ');
        for (i in word_list) {
            w = word_list[i];
            if (!wordmap.hasOwnProperty(w)) {
                wordmap[w] = 0;
            }
            wordmap[w]++;
        }
    });

    d3.layout.cloud().size([900, 600])
        .words(d3.entries(wordmap).map(function (d) {
            return { text: d.key, size: d.value };
        }))
        .padding(1)
        .rotate(0)
        .font("Impact")
        .fontSize(function (d) { return d.size * 10; })
        .on("end", draw)
        .start();

    function draw(words) {
        d3.select("body").append("svg")
            .attr("width", 900)
            .attr("height", 600)
        .append("g")
            .attr("transform", "translate(450,300)")
        .selectAll("text")
            .data(words)
        .enter().append("text")
            .style("font-size", function (d) { return d.size + "px"; })
            .style("font-family", "Impact")
            .style("fill", function (d, i) { return fill(i); })
            .attr("text-anchor", "middle")
            .attr("transform", function (d) {
                return "translate(" + [d.x, d.y] + ")rotate(" + d.rotate + ")";
            })
        .text(function (d) { return d.text; });
    }
})();