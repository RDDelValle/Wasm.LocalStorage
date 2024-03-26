// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function setItem(key, value) {
    localStorage.setItem(key, value);
}

export function getItem(key) {
    return localStorage.getItem(key);
}

export function removeItem(key) {
    localStorage.removeItem(key);
}

export function clear() {
    localStorage.clear();
}
