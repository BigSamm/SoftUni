<?php

/* anime/create.html.twig */
class __TwigTemplate_abd80478d8bc43ee04857dcd6cae94a8d053fbc1863bfb20f18d5073bc9039d4 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "anime/create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_beda13da056b89bc60fac78517b063bf29ec7c20e6a45e1420777a087b635c26 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_beda13da056b89bc60fac78517b063bf29ec7c20e6a45e1420777a087b635c26->enter($__internal_beda13da056b89bc60fac78517b063bf29ec7c20e6a45e1420777a087b635c26_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/create.html.twig"));

        $__internal_bc16c0969d8301ba089df76e0c57620d7d61a701ced6777af54f80ca1e7f9a09 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bc16c0969d8301ba089df76e0c57620d7d61a701ced6777af54f80ca1e7f9a09->enter($__internal_bc16c0969d8301ba089df76e0c57620d7d61a701ced6777af54f80ca1e7f9a09_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "anime/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_beda13da056b89bc60fac78517b063bf29ec7c20e6a45e1420777a087b635c26->leave($__internal_beda13da056b89bc60fac78517b063bf29ec7c20e6a45e1420777a087b635c26_prof);

        
        $__internal_bc16c0969d8301ba089df76e0c57620d7d61a701ced6777af54f80ca1e7f9a09->leave($__internal_bc16c0969d8301ba089df76e0c57620d7d61a701ced6777af54f80ca1e7f9a09_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_a76ed78aaaef2de352963c23b490590ffaff3fa4e8b135a7e0b52efc349a7e4b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a76ed78aaaef2de352963c23b490590ffaff3fa4e8b135a7e0b52efc349a7e4b->enter($__internal_a76ed78aaaef2de352963c23b490590ffaff3fa4e8b135a7e0b52efc349a7e4b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_64a65aea1c8da84a132f52d6cd7b6097c68edb4a8b88320a4383d9a23c3033fd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_64a65aea1c8da84a132f52d6cd7b6097c68edb4a8b88320a4383d9a23c3033fd->enter($__internal_64a65aea1c8da84a132f52d6cd7b6097c68edb4a8b88320a4383d9a23c3033fd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Add New Anime</h1>
<section>
    <form method=\"POST\" onsubmit=\"checkValue()\">
        <div>
            <label for=\"rating\">Rating</label>
            <input type=\"text\" id=\"rating\" name=\"anime[rating]\" value=\"0\">
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"anime[name]\">
            <label for=\"description\">Description</label>
            <input type=\"text\" id=\"description\" name=\"anime[description]\" value=\"...\">
            <label for=\"watched\">Watched</label>
            <input type=\"checkbox\" id=\"watched\" value=\"not watched\" name=\"anime[watched]\" onclick=\"switchValue()\">
            <label for=\"watched\" id=\"watched-label\"></label>
            ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" class=\"cancel\" onclick=\"location.href='/'\">Cancel</button>
        </div>
    </form>
</section>

<script>
    function switchValue() {
        document.getElementById(\"watched\").value =
            document.getElementById(\"watched\").value === \"watched\" ? \"not watched\" : \"watched\";
    }

    function checkValue() {
        document.getElementById(\"watched\").checked = true;
    }

    (function checkBox() {
        let checkbox = document.getElementById(\"watched\");
        checkbox.checked = checkbox.value !== \"not watched\";
    })();
</script>
";
        
        $__internal_64a65aea1c8da84a132f52d6cd7b6097c68edb4a8b88320a4383d9a23c3033fd->leave($__internal_64a65aea1c8da84a132f52d6cd7b6097c68edb4a8b88320a4383d9a23c3033fd_prof);

        
        $__internal_a76ed78aaaef2de352963c23b490590ffaff3fa4e8b135a7e0b52efc349a7e4b->leave($__internal_a76ed78aaaef2de352963c23b490590ffaff3fa4e8b135a7e0b52efc349a7e4b_prof);

    }

    public function getTemplateName()
    {
        return "anime/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  64 => 17,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>Add New Anime</h1>
<section>
    <form method=\"POST\" onsubmit=\"checkValue()\">
        <div>
            <label for=\"rating\">Rating</label>
            <input type=\"text\" id=\"rating\" name=\"anime[rating]\" value=\"0\">
            <label for=\"name\">Name</label>
            <input type=\"text\" id=\"name\" name=\"anime[name]\">
            <label for=\"description\">Description</label>
            <input type=\"text\" id=\"description\" name=\"anime[description]\" value=\"...\">
            <label for=\"watched\">Watched</label>
            <input type=\"checkbox\" id=\"watched\" value=\"not watched\" name=\"anime[watched]\" onclick=\"switchValue()\">
            <label for=\"watched\" id=\"watched-label\"></label>
            {{ form_row(form._token) }}

            <button type=\"submit\" class=\"accept\">Create</button>
            <button type=\"button\" class=\"cancel\" onclick=\"location.href='/'\">Cancel</button>
        </div>
    </form>
</section>

<script>
    function switchValue() {
        document.getElementById(\"watched\").value =
            document.getElementById(\"watched\").value === \"watched\" ? \"not watched\" : \"watched\";
    }

    function checkValue() {
        document.getElementById(\"watched\").checked = true;
    }

    (function checkBox() {
        let checkbox = document.getElementById(\"watched\");
        checkbox.checked = checkbox.value !== \"not watched\";
    })();
</script>
{% endblock %}", "anime/create.html.twig", "D:\\PHP Solution\\app\\Resources\\views\\anime\\create.html.twig");
    }
}
