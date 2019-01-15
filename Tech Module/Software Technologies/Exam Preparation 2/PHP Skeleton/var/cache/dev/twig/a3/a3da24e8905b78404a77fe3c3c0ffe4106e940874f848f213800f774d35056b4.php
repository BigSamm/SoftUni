<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_2187a738c070e396893dbf20cc0587d5cf0df08368a74d9e2ca98cb9f056d8c0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2187a738c070e396893dbf20cc0587d5cf0df08368a74d9e2ca98cb9f056d8c0->enter($__internal_2187a738c070e396893dbf20cc0587d5cf0df08368a74d9e2ca98cb9f056d8c0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_a4f5f842f298b1f5f9ef5341b16f4143011dbbca61b20e73037cf777fa6e0ec8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a4f5f842f298b1f5f9ef5341b16f4143011dbbca61b20e73037cf777fa6e0ec8->enter($__internal_a4f5f842f298b1f5f9ef5341b16f4143011dbbca61b20e73037cf777fa6e0ec8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 18
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 21
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 22
        $this->displayBlock('body', $context, $blocks);
        // line 25
        echo "</body>
</html>
";
        
        $__internal_2187a738c070e396893dbf20cc0587d5cf0df08368a74d9e2ca98cb9f056d8c0->leave($__internal_2187a738c070e396893dbf20cc0587d5cf0df08368a74d9e2ca98cb9f056d8c0_prof);

        
        $__internal_a4f5f842f298b1f5f9ef5341b16f4143011dbbca61b20e73037cf777fa6e0ec8->leave($__internal_a4f5f842f298b1f5f9ef5341b16f4143011dbbca61b20e73037cf777fa6e0ec8_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_2f10cdff57e4761399fc886108f061692aaf0933ab361991feb95a79043e1ff3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2f10cdff57e4761399fc886108f061692aaf0933ab361991feb95a79043e1ff3->enter($__internal_2f10cdff57e4761399fc886108f061692aaf0933ab361991feb95a79043e1ff3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_1813ff8d8dd4bba8b326ac3a5b8d8fa2dde49f1487c633d3bbd69d4c18895fe0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1813ff8d8dd4bba8b326ac3a5b8d8fa2dde49f1487c633d3bbd69d4c18895fe0->enter($__internal_1813ff8d8dd4bba8b326ac3a5b8d8fa2dde49f1487c633d3bbd69d4c18895fe0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "TODO List";
        
        $__internal_1813ff8d8dd4bba8b326ac3a5b8d8fa2dde49f1487c633d3bbd69d4c18895fe0->leave($__internal_1813ff8d8dd4bba8b326ac3a5b8d8fa2dde49f1487c633d3bbd69d4c18895fe0_prof);

        
        $__internal_2f10cdff57e4761399fc886108f061692aaf0933ab361991feb95a79043e1ff3->leave($__internal_2f10cdff57e4761399fc886108f061692aaf0933ab361991feb95a79043e1ff3_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_4847c32bb0cc2209e2956da2f4e240dcb80836b32250b4eecbcf6643b263066e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4847c32bb0cc2209e2956da2f4e240dcb80836b32250b4eecbcf6643b263066e->enter($__internal_4847c32bb0cc2209e2956da2f4e240dcb80836b32250b4eecbcf6643b263066e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_8347007a587d081d52f0332314bb75c0b752d80c99d4ee5f2dc9ce0b1801afb8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8347007a587d081d52f0332314bb75c0b752d80c99d4ee5f2dc9ce0b1801afb8->enter($__internal_8347007a587d081d52f0332314bb75c0b752d80c99d4ee5f2dc9ce0b1801afb8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/index-style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 16
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/form-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_8347007a587d081d52f0332314bb75c0b752d80c99d4ee5f2dc9ce0b1801afb8->leave($__internal_8347007a587d081d52f0332314bb75c0b752d80c99d4ee5f2dc9ce0b1801afb8_prof);

        
        $__internal_4847c32bb0cc2209e2956da2f4e240dcb80836b32250b4eecbcf6643b263066e->leave($__internal_4847c32bb0cc2209e2956da2f4e240dcb80836b32250b4eecbcf6643b263066e_prof);

    }

    // line 21
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_971d2a6446b903198643e246e6b3d3c6a6a4c4c3b0d6164e8a6b66e239af0b1c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_971d2a6446b903198643e246e6b3d3c6a6a4c4c3b0d6164e8a6b66e239af0b1c->enter($__internal_971d2a6446b903198643e246e6b3d3c6a6a4c4c3b0d6164e8a6b66e239af0b1c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_f02eb555aae327add88d6197073c1fd699cd47660c2d7b4330ac6e59abb34b72 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f02eb555aae327add88d6197073c1fd699cd47660c2d7b4330ac6e59abb34b72->enter($__internal_f02eb555aae327add88d6197073c1fd699cd47660c2d7b4330ac6e59abb34b72_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_f02eb555aae327add88d6197073c1fd699cd47660c2d7b4330ac6e59abb34b72->leave($__internal_f02eb555aae327add88d6197073c1fd699cd47660c2d7b4330ac6e59abb34b72_prof);

        
        $__internal_971d2a6446b903198643e246e6b3d3c6a6a4c4c3b0d6164e8a6b66e239af0b1c->leave($__internal_971d2a6446b903198643e246e6b3d3c6a6a4c4c3b0d6164e8a6b66e239af0b1c_prof);

    }

    // line 22
    public function block_body($context, array $blocks = array())
    {
        $__internal_0ad655c69af6485f3242d75c3615ee55ce592f3f83bd2ac33f27110265823e44 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0ad655c69af6485f3242d75c3615ee55ce592f3f83bd2ac33f27110265823e44->enter($__internal_0ad655c69af6485f3242d75c3615ee55ce592f3f83bd2ac33f27110265823e44_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_218fb7ac5435c050484656c70b583460c9c471f40487fa730edc5cad5f5d1a32 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_218fb7ac5435c050484656c70b583460c9c471f40487fa730edc5cad5f5d1a32->enter($__internal_218fb7ac5435c050484656c70b583460c9c471f40487fa730edc5cad5f5d1a32_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 23
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_218fb7ac5435c050484656c70b583460c9c471f40487fa730edc5cad5f5d1a32->leave($__internal_218fb7ac5435c050484656c70b583460c9c471f40487fa730edc5cad5f5d1a32_prof);

        
        $__internal_0ad655c69af6485f3242d75c3615ee55ce592f3f83bd2ac33f27110265823e44->leave($__internal_0ad655c69af6485f3242d75c3615ee55ce592f3f83bd2ac33f27110265823e44_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_09330760b28a352ab372cd5e12f6a4228a618d983895c6142d5b71b64bf034a4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_09330760b28a352ab372cd5e12f6a4228a618d983895c6142d5b71b64bf034a4->enter($__internal_09330760b28a352ab372cd5e12f6a4228a618d983895c6142d5b71b64bf034a4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_8181dc6ab3ac51832442c703567ec3cae0802ac15f97dd8df85f7ef28d25569b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8181dc6ab3ac51832442c703567ec3cae0802ac15f97dd8df85f7ef28d25569b->enter($__internal_8181dc6ab3ac51832442c703567ec3cae0802ac15f97dd8df85f7ef28d25569b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_8181dc6ab3ac51832442c703567ec3cae0802ac15f97dd8df85f7ef28d25569b->leave($__internal_8181dc6ab3ac51832442c703567ec3cae0802ac15f97dd8df85f7ef28d25569b_prof);

        
        $__internal_09330760b28a352ab372cd5e12f6a4228a618d983895c6142d5b71b64bf034a4->leave($__internal_09330760b28a352ab372cd5e12f6a4228a618d983895c6142d5b71b64bf034a4_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  142 => 23,  133 => 22,  116 => 21,  104 => 16,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 25,  54 => 22,  50 => 21,  43 => 18,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}TODO List{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/index-style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/form-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "D:\\PHP Skeleton 2\\app\\Resources\\views\\base.html.twig");
    }
}
