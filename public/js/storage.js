window.appStorage = {
    set: function (k, v) { localStorage.setItem(k, v); },
    get: function (k) { return localStorage.getItem(k); },
    remove: function (k) { localStorage.removeItem(k); }
};
