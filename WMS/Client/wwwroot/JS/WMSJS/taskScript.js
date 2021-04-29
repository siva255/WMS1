$(document).ready(function () {

    /** tree menu load start**/
    var treeList = $('.menuListInner li ul li');
    if (treeList.length > 0) {
        treeList.parent().parent().addClass('treeNode');
    } else {

    }
    /** tree menu load end**/

    /** tree menu click start**/
    $('.childNode li').click(function () {
        $('.childNode li').removeClass('menuActive');
        $(this).addClass('menuActive');
    })
    /** tree menu click end**/

    /** tree menu accordion start**/
    $('.parentNode').click(function () {
        $('.treeList').removeClass('menuShow');
        $(this).parent().addClass('menuShow');
    })
    /** tree menu accordion end**/


    /** task area start**/
    $('.taskAreaListInner').click(function () {
        $('.taskDetails').addClass('showtaskDetails');
        var bodylistClass = $('.viewPortArea').attr("class");
        var bodylistClassSplit = bodylistClass.split(" ");
        var bodylistClassSplitName = bodylistClassSplit[1];
        if (bodylistClassSplitName == "gridView") {
            $('.rightSideBarInner').addClass('taskDetailsSplit');
            $('.viewPortArea').addClass('gridViewSplit');
        } else {
            $('.rightSideBarInner').removeClass('taskDetailsSplit');
        }

        $('.taskAreaList li').removeClass('active');
        $(this).addClass('active');
    })
    /** task area end**/


    /** task tablist start**/
    $('.tabList li').click(function () {
        $('.tabList li').removeClass('active');
        $(this).addClass('active');
        $('.tabInner').removeClass('tabShow');
        var TabName = $(this).attr("Tabid");
        $('#' + TabName).addClass('tabShow');
    })
    /** task tablist end**/

    /** task tablist start**/
    $('.taskTabHeader li').click(function () {
        $('.taskTabHeader li').removeClass('active');
        $(this).addClass('active');
        $('.tabBodyInner').removeClass('tabShow');
        var TabName = $(this).attr("Tabid");
        $('#' + TabName).addClass('tabShow');
    })
    /** task tablist end**/

    /** grid view and listview start **/
    $('.viewPortList li').click(function () {
        $('.viewPortList li').removeClass('active');
        var bodylistClass = $('.viewPortArea').attr("class");
        var bodylistClassSplit = bodylistClass.split(" ");
        var bodylistClassSplitName = bodylistClassSplit[1];
        if (bodylistClassSplitName == "gridView") {
            $('.viewPortArea').removeClass('gridView');
        } else {
            $('.viewPortArea').removeClass('listView');
        }
        var buttonClass = $(this).children().attr("class");
        if (buttonClass == "gridView") {
            $(this).addClass('active');
            $('.viewPortArea').addClass('gridView');
        } else {
            $(this).addClass('active');
            $('.viewPortArea').addClass('listView');
            $('.rightSideBarInner').removeClass('taskDetailsSplit');
        }
    })
    /** grid view and listview  end**/

    /**  task close button start **/
    $('.taskCloseButton').click(function () {
        $('.taskDetails').removeClass('showtaskDetails');
    })
    /**  task close button end **/

    /** collapse start **/
    $('.groupTaskHead').click(function () {
        // $('.groupTaskHead').removeClass('active');
        if ($(this).hasClass('active') == true) {
            $(this).removeClass('active');
            $(this).next().removeClass('active');
        } else {
            $(this).addClass('active');
            $(this).next().addClass('active');
        }
        // $('.groupTaskInner').removeClass('active');

    })
    /** collapse end **/
    /** book click event**/
    $('.bookName').click(function () {
        $('.bookNameList').toggleClass('showFilter');
    })
    /** book click event**/

});

