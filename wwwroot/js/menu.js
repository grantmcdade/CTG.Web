$(document).ready(function () {
    var menuTriggers = $('.menu-trigger');
    menuTriggers.each((index, menuTrigger) => {
        const showMenuClassName = 'show-menu';
        //console.log(menuTrigger);
        var $menuTrigger = $(menuTrigger);
        var subMenuName = $menuTrigger.data('menu');
        var subMenu = $(subMenuName);
        var menuTimeout = null;

        $menuTrigger.on('mouseover', function () {
            subMenu.addClass(showMenuClassName);
            if (menuTimeout) {
                //console.log('Clearing hide menu timer');
                clearTimeout(menuTimeout);
                menuTimeout = null;
            }
            //console.log('Showing menu');
        })

        $menuTrigger.on('mouseout', function () {
            if (!menuTimeout) {
                //console.log('Adding hide menu timer');
                menuTimeout = setTimeout(() => {
                    //console.log('Hiding menu');
                    subMenu.removeClass(showMenuClassName);
                    menuTimeout = null;
                }, 200);
            } 
        })
    });
});