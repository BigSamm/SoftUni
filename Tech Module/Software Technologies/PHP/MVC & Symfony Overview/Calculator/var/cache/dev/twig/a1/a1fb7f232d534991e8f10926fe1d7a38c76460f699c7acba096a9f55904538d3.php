<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_8db07901cb12c517d92d835b4680155d876b9c737e62fadc70c64ab45a040058 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_e9228f25ae467d913e36d2b7dac05b90e092e945cca78b858ddf0bae3023e9af = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e9228f25ae467d913e36d2b7dac05b90e092e945cca78b858ddf0bae3023e9af->enter($__internal_e9228f25ae467d913e36d2b7dac05b90e092e945cca78b858ddf0bae3023e9af_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_e9228f25ae467d913e36d2b7dac05b90e092e945cca78b858ddf0bae3023e9af->leave($__internal_e9228f25ae467d913e36d2b7dac05b90e092e945cca78b858ddf0bae3023e9af_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_fba64ef2458ab2382a9d9d2b3c885d51ae9196b4e200dcef1db875ffc600fe9f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fba64ef2458ab2382a9d9d2b3c885d51ae9196b4e200dcef1db875ffc600fe9f->enter($__internal_fba64ef2458ab2382a9d9d2b3c885d51ae9196b4e200dcef1db875ffc600fe9f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_fba64ef2458ab2382a9d9d2b3c885d51ae9196b4e200dcef1db875ffc600fe9f->leave($__internal_fba64ef2458ab2382a9d9d2b3c885d51ae9196b4e200dcef1db875ffc600fe9f_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_cd1db6afbae69100a8307ed11390c1458fa7cc4e5f592a608bf61ebdc05842e6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cd1db6afbae69100a8307ed11390c1458fa7cc4e5f592a608bf61ebdc05842e6->enter($__internal_cd1db6afbae69100a8307ed11390c1458fa7cc4e5f592a608bf61ebdc05842e6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_cd1db6afbae69100a8307ed11390c1458fa7cc4e5f592a608bf61ebdc05842e6->leave($__internal_cd1db6afbae69100a8307ed11390c1458fa7cc4e5f592a608bf61ebdc05842e6_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_5d093185e7661dfd6f532bddcb1d63e631bf1f9d9da147accc8cdcde0189bfe6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5d093185e7661dfd6f532bddcb1d63e631bf1f9d9da147accc8cdcde0189bfe6->enter($__internal_5d093185e7661dfd6f532bddcb1d63e631bf1f9d9da147accc8cdcde0189bfe6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_5d093185e7661dfd6f532bddcb1d63e631bf1f9d9da147accc8cdcde0189bfe6->leave($__internal_5d093185e7661dfd6f532bddcb1d63e631bf1f9d9da147accc8cdcde0189bfe6_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
