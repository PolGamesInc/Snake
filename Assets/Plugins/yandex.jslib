mergeInto(LibraryManager.library,{

  ShowFullscreen: function () {
      ysdk.adv.showFullscreenAdv({
      callbacks: {
          onOpen: function(wasShown) {
            console.Log("Fullscreen start");
          },
          onClose: function(wasShown) {
            console.Log("Fullscreen end");
          },
          onError: function(error) {
            console.Log("Fullscreen error");
          }
      }
      })
  },

})