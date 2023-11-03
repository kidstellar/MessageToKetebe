mergeInto(LibraryManager.library, {
  SendMessageToKetebe: function(param)
  {
    var encodedParam = encodeURIComponent(Pointer_stringify(param));
    window.location.assign("uniwebview://event?payload=" + encodedParam)
  },
});