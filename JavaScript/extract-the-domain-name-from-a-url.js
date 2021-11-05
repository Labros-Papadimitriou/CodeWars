function domainName(url) {
  url = url.replace("https://", "");
  url = url.replace("http://", "");
  url = url.replace("www.", "");
  
  return url.split(".")[0];
}
