/*
	For Edit This File Please Read Documentation
*/

var myPlaylist = [
	
	{
		mp3:'http://a905.phobos.apple.com/us/r1000/152/Music1/v4/20/94/04/209404b2-9156-ab14-55f6-1eddd591028a/mzaf_7278193144919922203.plus.aac.p.m4a',
		oga:'music/5.ogg',
		title:'Policeman',
		artist:'Eva Simons ft. Konshens',
		rating:5,
		duration:'3:13',
		cover:'/Content/MyTemplate/music/180x180.png'	
	},
	{
		mp3:'http://a1546.phobos.apple.com/us/r1000/165/Music3/v4/10/a6/d1/10a6d1e4-6dd7-5cb1-f62f-7e82869bc4fe/mzaf_108084490980764450.plus.aac.p.m4a',
		oga:'music/4.ogg',
		title:'Hula Hoop',
		artist:'Omi',
		rating:4,
		duration:'3:22',
		cover:'/Content/MyTemplate/music/180x180.jpg'	
	},		
	{
		mp3:'http://a1721.phobos.apple.com/us/r2000/001/Music69/v4/4a/f5/ec/4af5ecd7-8a4f-dd77-530d-e5cf00454b74/mzaf_5259415513100213857.plus.aac.p.m4a',
		oga:'music/1.ogg',
		title:'Baila Conmigo',
		artist:'Juan Magan Feat. Luciana',
		rating:5,		
		duration:'3:10',
		cover:'/Content/MyTemplate/music/180x180.jpg'
	},
	{
		mp3:'http://a52.phobos.apple.com/us/r1000/022/Music1/v4/27/df/37/27df37a4-c872-8cec-eeb2-79f9efe78a13/mzaf_4133487949051081991.plus.aac.p.m4a',
		oga:'music/6.ogg',
		title:'GDFR',
		artist:'Flo Rida Feat. Sage The Gemini & Lookas',
		rating:5,
		duration:'3:45',
		cover:'/Content/MyTemplate/music/180x180.jpg'	
	},
	{
		mp3:'http://a422.phobos.apple.com/us/r1000/051/Music3/v4/a8/46/32/a8463217-9081-df6a-19ea-62767a6e51fd/mzaf_382956838611102579.plus.aac.p.m4a',
		oga:'music/2.ogg',
		title:'La Mordidita',
		artist:'Ricky Martin Feat. Yotuel',
		rating:4,
		duration:'3:36',
		cover:'/Content/MyTemplate/music/180x180.jpg'	
	},
	{
		mp3:'http://a1492.phobos.apple.com/us/r1000/131/Music4/v4/5b/8c/3a/5b8c3aae-8a3e-08d8-2407-9965d9b4a4b6/mzaf_5318239526424474500.plus.aac.p.m4a',
		oga:'music/3.ogg',
		title:'Madre Tierra (Oye)',
		artist:'Chayanne',
		rating:5,
		duration:'3:31',
		cover:'/Content/MyTemplate/music/180x180.jpg'	
	}
];
jQuery(document).ready(function ($) {
	$('.music-player-list').ttwMusicPlayer(myPlaylist, {
		currencySymbol:'$',
		buyText:'BUY',
		tracksToShow:3,
		autoplay:true,
		ratingCallback:function(index, playlistItem, rating){
			//some logic to process the rating, perhaps through an ajax call
		},
		jPlayer:{
			swfPath:'http://www.jplayer.org/2.1.0/js'
		}
	});
});